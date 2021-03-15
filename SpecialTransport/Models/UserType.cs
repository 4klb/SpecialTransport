using System;
using System.Collections.Generic;
using System.Text;

namespace SpecialTransport.Models
{
    public class UserType : Entity
    {
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
    }
}
