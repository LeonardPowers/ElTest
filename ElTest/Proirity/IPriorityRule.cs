using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElTest.Model;

namespace ElTest.Proirity
{
    public interface IPriorityRule
    {
        int Priority(ElRequestDto client);
    }
}
