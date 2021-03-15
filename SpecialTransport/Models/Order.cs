using SpecialTrancport.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecialTransport.Models
{
    public class Order : Entity
    {

        //Координаты - точка на карте
        public string Coordinates { get; set; }

        //ТипТехники
        public Guid TransportId { get; set; }
        public Transport Transport { get; set; }

        //Статус заказа
        public Guid StatusId { get; set; }
        public Status Status { get; set; }

        //Цена заказа
        public double cost { get; set; }

        //Описание заказа
        public string Description { get; set; }

        //Заказчик
        public Guid customerId { get; set; }
        public User customer { get; set; }

        //Исполнитель
        public Guid ExecutorId { get; set; }
        public User Executor { get; set; }

    }
}
