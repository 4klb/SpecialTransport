using System;
using System.Collections.Generic;
using System.Text;

namespace SpecialTransport.Models
{
    public class Mark : Entity
    {
        ICollection<Order> Orders { get; set; }
        ICollection<User> Users { get; set; }
    }
}
