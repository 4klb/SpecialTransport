using System;
using System.Collections.Generic;
using System.Text;

namespace SpecialTransport.Models
{
    public class Recovery : Entity
    {
        public User UserId { get; set; }
        public User User { get; set; }
    }
}
