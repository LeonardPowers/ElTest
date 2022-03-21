using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElTest.Model;

namespace ElTest.Repository
{
    public interface IElRepository
    {
        ElClient GetClient(Guid guid);

        bool IsFirstRequest(Guid guid);



    }
}
