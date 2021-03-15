using System;
using System.Collections.Generic;
using System.Text;

namespace SpecialTransport.Models
{
    public class User : Entity
    {
        public Guid UserTypeId { get; set; }
        public UserType UserType { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}
