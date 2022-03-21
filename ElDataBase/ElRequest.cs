using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElTest.Model
{
    public class ElRequest
    {
        [Key]
        public Guid Id { get; set; }
        public EnumRequestType RequestType { get; set; }
        public EnumChennelType ChannelType { get; set; }

        public DateTime CreationTime { get; set; }

        public Guid ClientId { get; set; }

        public byte[] Body { get; set; }

        public byte[] Response { get; set; }

        public string ModelUrl { get; set; } 
    }
}
