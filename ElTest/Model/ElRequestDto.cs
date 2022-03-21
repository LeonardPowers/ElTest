using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElTest.Model
{
    public class ElRequestDto
    {
        public EnumRequestType RequestType { get; set; }

        public DateTime CreationTime { get; set; }

        public Guid ClientId { get; set; }

        public byte Priority { get; set; }

        public string ModelUrl { get; set; }
    }
}
