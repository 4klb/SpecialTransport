using System;
using System.Collections.Generic;
using System.Text;

namespace SpecialTransport.Models
{
    public class Work : Entity
    {
        public Guid UserId { get; set; }
        public User Users { get; set; }
        public Guid OrderId { get; set; }
        public User Orders { get; set; }
    }
}
