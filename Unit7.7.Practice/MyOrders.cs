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
            List<ProductInfo> productInfos = new List<ProductInfo>();
            ProductInfo productInfo = new ProductInfo();

            Products products = new Products("Книга", "\"Большая энциклопедия\"", 5.99, 3);
            Products products2 = new Products("Книга", "Герберт Шилдт \"C# 4.0: полное руководство\"", 8.89, 1);
            Products products3 = new Products("Игрушка", "модель легкового автомобиля \"Ford Focus\"", 4.79, 2);
            Products products4 = new Products("Игрушка", "кукла \"Barbie\"", 5.49, 1);

            Product book1 = new Product(products, 1);
            Product book2 = new Product(products2, 2);
            Product toy1 = new Product(products3, 3);
            Product toy2 = new Product(products4, 4);
            Console.WriteLine("В наличии есть:");
            book1.ShowProduct();
            book2.ShowProduct();
            toy1.ShowProduct();
            toy2.ShowProduct();

            while (!flagForExit)
            {
                Console.WriteLine("\nУкажите номер товара, который хотите выбрать или для выхода напишите: Выход");
                var userEnter = Console.ReadLine();
                if (int.TryParse(userEnter, out numberSelectedProduct) && numberSelectedProduct > 0 && numberSelectedProduct < 5)
                {
                    switch (numberSelectedProduct)
                    {
                        case 1:
                            AddToOrder(products, book1, ref productInfos, ref productInfo);
                            break;
                        case 2:
                            AddToOrder(products2, book2, ref productInfos, ref productInfo);
                            break;
                        case 3:
                            AddToOrder(products3, toy2, ref productInfos, ref productInfo);
                            break;
                        case 4:
                            AddToOrder(products4, toy2, ref productInfos, ref productInfo);
                            break;
                    }
                    foreach (var item2 in productsAdd.productInfos)
                    {
                        Console.WriteLine(item.ProductTypeInf + " " + "1 шт. " + item.ProductNameInf + " стоимостью " + item.ProductPriceInf + "$");
                    }

                }
                else
                    Console.WriteLine("Указано неверное значение!");
                if (userEnter == "Выход")
                    flagForExit = true;
            }




            Console.WriteLine("У вас в заказе:");
            Shop shop = new Shop();
            shop.GetDeliveryType();
        }
        private void AddToOrder(Products productsAdd, Product productAdd, ref List<ProductInfo> productInfosAdd, ref ProductInfo productInfoAdd)
        {
            Console.WriteLine("Добавлено в заказ: {0} {1}.\nВаш заказ:", productsAdd.ProductType, productsAdd.ProductName);
            productAdd.GetProduct();
            foreach (var item in productsAdd.productInfos)
            {
                Console.WriteLine(item.ProductTypeInf + " " + "1 шт. " + item.ProductNameInf + " стоимостью " + item.ProductPriceInf + "$");
            }

            //productInfosAdd.Add(productInfoAdd);

        }
    }
}
