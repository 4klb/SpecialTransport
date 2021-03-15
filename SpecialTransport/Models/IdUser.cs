using System;
using System.Collections.Generic;
using System.Text;

namespace IdUserRecovery.TaskUser
{
    public class IdUser
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Data { get; set; }
    }
}
