using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7._7.Practice
{
    class Shop
    {

        public void GetDeliveryType()
        {
            bool flagForExit = false;
            int selectDeliveryType;
            string[] deliveryType = { "Доставка на дом", "Доставка в один из наших магазинов", "Покупка в этом магазине" };

            while (!flagForExit)
            {
                Console.WriteLine("Выберите способ доставки (Для выхода напишите Выход): ");
                for (int i = 0; i < deliveryType.Length; i++)
                {
                    Console.WriteLine(i + 1 + " - " + deliveryType[i]);
                }
                var userEnter = Console.ReadLine();
                if (int.TryParse(userEnter, out selectDeliveryType) && selectDeliveryType > 0 && selectDeliveryType < 4)
                {
                    switch (selectDeliveryType)
                    {
                        case 1:
                            Order<HomeDelivery> order1 = new Order<HomeDelivery>();
                            order1.Delivery = new HomeDelivery();
                            order1.Delivery.GetDeliveryAddress();
                            order1.DisplayAddress();
                            Console.WriteLine("Доставить почтой или курьером?");
                            var enterHomeDelivery = Console.ReadLine();
                            if (enterHomeDelivery == "почтой" || enterHomeDelivery == "Почтой")
                            {

                            }
                            else if (enterHomeDelivery == "курьером" || enterHomeDelivery == "Курьером")
                            {

                            }
                            else
                            {
                                Console.WriteLine("Не выбран способ доставки!");
                                break;
                            }
                            flagForExit = true;
                            break;
                        case 2:
                            Order<PickPointDelivery> order2 = new Order<PickPointDelivery>();
                            order2.Delivery = new PickPointDelivery();
                            order2.Delivery.GetDeliveryAddress();
                            order2.DisplayAddress();

                            flagForExit = true;
                            break;
                        case 3:
                            Order<ShopDelivery> order3 = new Order<ShopDelivery>();
                            order3.Delivery = new ShopDelivery();
                            order3.Delivery.GetDeliveryAddress();
                            order3.DisplayAddress();
                            flagForExit = true;
                            break;
                    }
                }
                else
                {
                    if (userEnter != "Выход")
                        Console.WriteLine("Указано неверное значение!");
                }
                if (userEnter == "Выход")
                    flagForExit = true;

            }
        }
    }
}
