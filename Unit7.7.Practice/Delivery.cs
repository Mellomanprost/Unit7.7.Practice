using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7._7.Practice
{
    public abstract class Delivery
    {
        protected internal string Address;
        public virtual void GetDeliveryAddress()
        {
            Address = (Console.ReadLine()).ToString();
        }
    }

    public class HomeDelivery : Delivery
    {
        public override void GetDeliveryAddress()
        {
            Console.Write("Введите адрес доставки: ");
            base.GetDeliveryAddress();
        }
        public void GetDeliveryAddressForCourier()
        {
            GetDeliveryAddress();
            if (Address != "")
                Console.WriteLine("Ваш заказ будет доставлен курьером в течении 2 дней по адресу: " + Address);
        }

    }

    public class PickPointDelivery : Delivery
    {
        (string firstShop, string secondShop, string thirdShop) Shops;
        public override void GetDeliveryAddress()
        {
            int selectShop;
            bool flagForExit = false;
            Shops.firstShop = "г.Минск, пр-т Машерова 33";
            Shops.secondShop = "г.Минск, пр-т Независимости 99";
            Shops.thirdShop = "г.Минск, пр-т Держинского 104";

            Console.WriteLine("Выберите адрес магазина в котором вы хотите забрать товар.");
            Console.WriteLine("1 - " + Shops.firstShop + "\n2 - " + Shops.secondShop + "\n3 - " + Shops.thirdShop);
            Console.WriteLine("Для выбора адреса введите номер, который указан перед ним.");

            while (!flagForExit)
            {
                Console.WriteLine("Выберите магазин: ");
                var iSInt = Console.ReadLine();
                if (int.TryParse(iSInt, out selectShop) && selectShop > 0 && selectShop < 4)
                {
                    switch (selectShop)
                    {
                        case 1:
                            Address = Shops.firstShop;
                            flagForExit = true;
                            break;
                        case 2:
                            Address = Shops.secondShop;
                            flagForExit = true;
                            break;
                        case 3:
                            Address = Shops.thirdShop;
                            flagForExit = true;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Указано неверное значение!\nДля выхода напишите: Выход");
                    if (iSInt == "Выход" || iSInt == "выход")
                        flagForExit = true;
                }
            }
            if (Address != null)
                Console.WriteLine("Вы выбрали магазин " + Address);
            else
                Console.WriteLine("Магазин не выбран!");
        }
    }

    public class ShopDelivery : Delivery
    {
        private string shopName = "10element";
        public override void GetDeliveryAddress()
        {
            Address = "у главного входа магазина " + shopName;
            Console.Write("Для покупки товара пройдите на кассу ");
        }
    }

}
