using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7._7.Practice
{
    class MyOrders
    {
        public void GetOrder()
        {
            Products products = new Products();
            Book book = new Book(products);
            Console.WriteLine("У вас в заказе:");
            book.GetBook("Большая энциклопедия", 5.99, 1);
            Shop shop = new Shop();
            shop.GetDeliveryType();
        }
    }
}
