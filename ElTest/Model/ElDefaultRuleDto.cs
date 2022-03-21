using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElTest.Proirity;

namespace ElTest.Model
{
    public class ElDefaultRuleDto
    {
        public ElDefaultRuleKvpDto[] WeightMap { get; set; }

        public string Name { get; set; }
    }
}
