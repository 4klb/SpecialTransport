using System;

namespace SpecialTransport.Models
{
    public class Transport : Entity
    {
        public string Name { get; set; }

        //ГосНомер
        public string StateNumber { get; set; }

        public Guid TransportTypeId { get; set; }
        public TransportType TransportType { get; set; }
    }
}