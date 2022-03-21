using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElTest.Model;
using ElTest.Repository;

namespace ElTest.Proirity
{
    public class PriorityManager
    {
        static PriorityManager()
        {
            PriorityRules = new Dictionary<string, IPriorityRule>();
        }


        private static Dictionary<string, IPriorityRule> PriorityRules;

        public static void Add(string name, IPriorityRule priorityRule)
        {
            if(PriorityRules.ContainsKey(name))
                throw  new Exception("Key already exists");
            PriorityRules[name] = priorityRule;
        }

        public static int GetPriority(string name, ElRequestDto request)
        {
            if (!PriorityRules.ContainsKey(name))
                throw new Exception("Key not exists");
            return PriorityRules[name].Priority(request);
        }


    }
}
