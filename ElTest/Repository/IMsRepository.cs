using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElTest.Model;

namespace ElTest.Repository
{
    public class IMsRepository:IElRepository
    {


        public ElClient GetClient(Guid guid)
        {
            throw new NotImplementedException();
        }

        public bool IsFirstRequest(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}
