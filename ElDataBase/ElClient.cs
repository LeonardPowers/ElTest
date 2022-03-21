using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace ElTest.Model
{
    public class ElClient
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public EnumClientType ClientType { get; set; }

        public List<ElRequest> Users { get; set; }
    }
}
