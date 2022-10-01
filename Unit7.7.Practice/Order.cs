using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7._7.Practice
{
    class Order<TDelivery> where TDelivery : Delivery
    //class Order<TDelivery, TStruct> where TDelivery : Delivery

    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);

        }
        //public void GetDeliveryType()
        //{
        //    bool flagForExit = false;
        //    int selectDeliveryType;
        //    Console.WriteLine("Выберите способ доставки:");
        //    while (!flagForExit)
        //    {
        //        Console.WriteLine("Выберите магазин: ");
        //        if (int.TryParse(Console.ReadLine(), out selectDeliveryType))
        //        {
        //            switch (selectDeliveryType)
        //            {
        //                case 1:
        //                    Description = y();
        //                    flagForExit = true;
        //                    break;
        //                case 2:
        //                    Address = Shops.secondShop;
        //                    flagForExit = true;
        //                    break;
        //                case 3:
        //                    Address = Shops.thirdShop;
        //                    flagForExit = true;
        //                    break;
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Указано неверное значение!\nДля выхода напишите: Выход");
        //            if (Console.ReadLine() == "Выход")
        //                flagForExit = true;
        //        }
        //    }

        //}
        // ... Другие поля
    }
}
