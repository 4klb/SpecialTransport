using System;
using System.Collections.Generic;
using System.Text;

namespace SpecialTransport.Models
{
    public class UserType : Role
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Role RoleId { get; set; }
        public Role Role { get; set; }
    }
}
