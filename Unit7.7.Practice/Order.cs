using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7._7.Practice
{
    class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery;
        public string[] Description = { "Доставка на дом (почтой либо курьером).", "Доставка в один из наших магазинов, расположенных по другому адресу.", "Покупка в этом магазине." };
        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }
    }
}
