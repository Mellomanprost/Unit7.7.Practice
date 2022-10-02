using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7._7.Practice
{
    class Shop
    {
        public readonly string shopName = "\"10element\"";

        public void GetDeliveryType()
        {
            bool flagForExit = false;
            Order<CurrentShop> order = new Order<CurrentShop>();
            Order<HomeDelivery> order1 = new Order<HomeDelivery>();
            order1.Delivery = new HomeDelivery();
            Order<PickPointDelivery> order2 = new Order<PickPointDelivery>();
            order2.Delivery = new PickPointDelivery();
            Order<ShopDelivery> order3 = new Order<ShopDelivery>();
            order3.Delivery = new ShopDelivery();

            while (!flagForExit)
            {
                Console.WriteLine("\nВыберите способ доставки (Для выхода напишите Выход): ");
                for (int i = 0; i < order.Description.Length; i++)
                {
                    Console.WriteLine(i + 1 + " - " + order.Description[i]);
                }
                var userEnter = Console.ReadLine();
                if (int.TryParse(userEnter, out int selectDeliveryType) && selectDeliveryType > 0 && selectDeliveryType < 4)
                {
                    switch (selectDeliveryType)
                    {
                        case 1:
                            Console.WriteLine("Доставка почтой осуществляется 5 дней, курьером в течении 2 дней.\nДоставить почтой или курьером?");
                            var enterHomeDelivery = Console.ReadLine();
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
                            order2.Delivery.GetDeliveryAddress();
                            Console.Write("Ваш товар в течении дня будет доставлен в наш магазин по адресу: ");
                            order2.DisplayAddress();
                            Console.WriteLine();
                            flagForExit = true;
                            break;
                        case 3:
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
