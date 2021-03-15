using SpecialTransport.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdUserRecovery.TaskUser
{
    public class UserOrder : Entity
    {
        public User UserId { get; set; }
        public User User { get; set; }
        public Order OrderId { get; set; }
        public Order Order { get; set; }
        public string Text { get; set; }
        public int Mark { get; set; }

    }
}
