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
            Order<HomeDelivery> order1 = new Order<HomeDelivery>();
            while (!flagForExit)
            {
                Console.WriteLine("\nВыберите способ доставки (Для выхода напишите Выход): ");
                for (int i = 0; i < order1.Description.Length; i++)
                {
                    Console.WriteLine(i + 1 + " - " + order1.Description[i]);
                }
                var userEnter = Console.ReadLine();
                if (int.TryParse(userEnter, out selectDeliveryType) && selectDeliveryType > 0 && selectDeliveryType < 4)
                {
                    switch (selectDeliveryType)
                    {
                        case 1:
                            Console.WriteLine("Доставка почтой осуществляется 5 дней, курьером в течении 2 дней.\nДоставить почтой или курьером?");
                            var enterHomeDelivery = Console.ReadLine();
                            order1.Delivery = new HomeDelivery();
                            if (enterHomeDelivery == "почтой" || enterHomeDelivery == "Почтой")
                            {
                                order1.Delivery.GetDeliveryAddress();
                                if (order1.Delivery.Address != "")
                                {
                                    order1.DisplayAddress();
                                    Console.WriteLine("Ваш заказ будет доставлен через 5 дней почтой по адресу: " + order1.Delivery.Address);
                                }
                                else
                                {
                                    Console.WriteLine("Адрес не указан!");
                                    break;
                                }
                            }
                            else if (enterHomeDelivery == "курьером" || enterHomeDelivery == "Курьером")
                            {
                                order1.Delivery.GetDeliveryAddressForCourier();
                                if (order1.Delivery.Address == "")
                                {
                                    Console.WriteLine("Адрес не указан!");
                                    break;
                                }
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
                            Console.Write("Ваш товар в течении дня будет доставлен в наш магазин по адресу: ");
                            order2.DisplayAddress();
                            Console.WriteLine();
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
                    if (userEnter != "Выход" && userEnter != "выход")
                        Console.WriteLine("Указано неверное значение!");
                }
                if (userEnter == "Выход" || userEnter == "выход")
                    flagForExit = true;
            }
        }
    }
}
