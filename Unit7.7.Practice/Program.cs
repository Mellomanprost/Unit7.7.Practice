using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7._7.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            MyOrders myOrders = new MyOrders();
            CurrentShop shop = new CurrentShop();
            shop.GetDeliveryAddress();
            Console.WriteLine("Добро пожаловать в наш магазин {0}!\n", shop.Address);
            myOrders.GetOrder();
        }
    }
}
