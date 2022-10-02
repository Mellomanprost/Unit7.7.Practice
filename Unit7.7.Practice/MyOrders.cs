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
            int numberSelectedProduct;
            bool flagForExit = false;
            Products products = new Products();
            Product book1 = new Product(products, 1);
            Product book2 = new Product(products, 2);
            Product toy1 = new Product(products, 3);
            Product toy2 = new Product(products, 4);
            Console.WriteLine("В наличии есть:");
            book1.ShowProduct("Книга", "\"Большая энциклопедия\"", 5.99, 3);
            book2.ShowProduct("Книга", "Герберт Шилдт \"C# 4.0: полное руководство\"", 8.89, 1);
            toy1.ShowProduct("Игрушка", "модель легкового автомобиля \"Ford Focus\"", 4.79, 2);
            toy2.ShowProduct("Игрушка", "кукла \"Barbie\"", 5.49, 1);
            Console.Write("Укажите номер товара, который хотите выбрать: ");
            
            while (!flagForExit)
            {
                Console.WriteLine("Укажите номер товара, который хотите выбрать: ");
                if (int.TryParse(Console.ReadLine(), out numberSelectedProduct) && numberSelectedProduct > 0 && numberSelectedProduct < 5)
                {
                    switch (numberSelectedProduct)
                    {
                        case 1:
                            Console.WriteLine("Добавлено в заказ: " + products.ProductType + " " + products.ProductName);
                            book1.GetProduct();
                            flagForExit = true;
                            break;
                        case 2:

                            flagForExit = true;
                            break;
                        case 3:
                            flagForExit = true;
                            break;
                        case 4:
                            flagForExit = true;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Указано неверное значение!\nДля выхода напишите: Выход");
                    Console.WriteLine("Или попробуйте еще раз.");
                    if (Console.ReadLine() == "Выход")
                        flagForExit = true;
                }
            }




            Console.WriteLine("У вас в заказе:");
            //book1.GetProduct("Книга", "\"Большая энциклопедия\"", 5.99, 1);
            Shop shop = new Shop();
            shop.GetDeliveryType();
        }
    }
}
