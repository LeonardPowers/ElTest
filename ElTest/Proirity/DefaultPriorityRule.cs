using ElTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElTest.Repository;

namespace ElTest.Proirity
{
    public class DefaultPriorityRule :  IPriorityRule
    {
        private IElRepository _repository = null;
        public Dictionary<EnumDefaultPriorityRuleKeys, int> WeightMap;
        private Dictionary<EnumDefaultPriorityRuleKeys, priroiryHandler> handlersMap;
        private delegate bool priroiryHandler(ElClient client, ElRequestDto requestDto);

        public DefaultPriorityRule(IElRepository elRepository)
        {
            _repository = elRepository;
            handlersMap[EnumDefaultPriorityRuleKeys.High] = handlerHigh;
            handlersMap[EnumDefaultPriorityRuleKeys.Super] = handlerSuper;
            handlersMap[EnumDefaultPriorityRuleKeys.IsDetail] = handlerIsDetail;
            handlersMap[EnumDefaultPriorityRuleKeys.IsFirst] = handlerIsFirst;
        }

        public int Priority(ElRequestDto elRequestDto)
        {
            ElClient client = _repository.GetClient(elRequestDto.ClientId);
            int total = 0;
            foreach (var item in WeightMap)
            {
                if (handlersMap[item.Key](client, elRequestDto))
                {
                    total += WeightMap[item.Key];
                }
            }
            return total;
        }

        public static Dictionary<EnumDefaultPriorityRuleKeys, int> GenerateForConsultation()
        {
            Dictionary<EnumDefaultPriorityRuleKeys, int> dictionary = new Dictionary<EnumDefaultPriorityRuleKeys, int>();
            dictionary[EnumDefaultPriorityRuleKeys.High] = 3;
            dictionary[EnumDefaultPriorityRuleKeys.Super] = 2;
            dictionary[EnumDefaultPriorityRuleKeys.IsFirst] = 2;
            dictionary[EnumDefaultPriorityRuleKeys.IsDetail] = 4;
            return dictionary;
        }
        public static Dictionary<EnumDefaultPriorityRuleKeys, int> GenerateForOrders()
        {
            Dictionary<EnumDefaultPriorityRuleKeys, int> dictionary = new Dictionary<EnumDefaultPriorityRuleKeys, int>();
            dictionary[EnumDefaultPriorityRuleKeys.High] = 3;
            dictionary[EnumDefaultPriorityRuleKeys.Super] = 4;
            dictionary[EnumDefaultPriorityRuleKeys.IsFirst] = 2;
            dictionary[EnumDefaultPriorityRuleKeys.IsDetail] = 1;
            return dictionary;
        }

        bool handlerHigh(ElClient client, ElRequestDto requestDto)
        {
            return client.ClientType == EnumClientType.High;
        }
        bool handlerSuper(ElClient client, ElRequestDto requestDto)
        {
            return client.ClientType == EnumClientType.Super;
        }

        bool handlerIsFirst(ElClient client, ElRequestDto requestDto)
        {
            return !string.IsNullOrEmpty(requestDto.ModelUrl);
        }

        bool handlerIsDetail(ElClient client, ElRequestDto requestDto)
{
            return _repository.IsFirstRequest(client.Id);
        }
    }
}
