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
            List<ProductInfo> myOrderList = new List<ProductInfo>();
            (string ProdType, string ProdName, double ProdPrice, int NumOfProd) ProdTuple = default;

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
                            GetProducts(products, ref ProdTuple);
                            break;
                        case 2:
                            GetProducts(products2, ref ProdTuple);
                            break;
                        case 3:
                            GetProducts(products3, ref ProdTuple);
                            break;
                        case 4:
                            GetProducts(products4, ref ProdTuple);
                            break;
                    }
                    GetProductsToList(ProdTuple, out ProductInfo productInfoList);
                    myOrderList.Add(productInfoList);
                    ShowMyOrder(myOrderList);
                }
                else if (userEnter != "Выход" && userEnter != "выход")
                {
                    Console.WriteLine("Указано неверное значение!");
                }

                if (userEnter == "Выход" || userEnter == "выход")
                    flagForExit = true;
            }
            Console.WriteLine("Ваш заказ:");
            ShowMyOrder(myOrderList);
            Shop shop = new Shop();
            shop.GetDeliveryType();
        }
        private void GetProducts(Products productsAdd, ref (string ProdType, string ProdName, double ProdPrice, int NumOfProd) prodTuple)
        {
            prodTuple.ProdType = productsAdd.ProductType;
            prodTuple.ProdName = productsAdd.ProductName;
            prodTuple.ProdPrice = productsAdd.ProductPrice;
            prodTuple.NumOfProd = 1;
        }
        public ProductInfo GetProductsToList((string ProdType, string ProdName, double ProdPrice, int NumOfProd) prodTupleToList, out ProductInfo productInfoList)
        {
            ProductInfo productInfo = new ProductInfo();
            productInfo.ProductTypeInf = prodTupleToList.ProdType;
            productInfo.ProductNameInf = prodTupleToList.ProdName;
            productInfo.ProductPriceInf = prodTupleToList.ProdPrice;
            productInfo.NumberOfProductsInf = prodTupleToList.NumOfProd;
            productInfoList = productInfo;
            return productInfoList;
        }
        public void ShowMyOrder(List<ProductInfo> orderList)
        {
            foreach (var item in orderList)
            {
                Console.WriteLine(item.ProductTypeInf + " " + "1 шт. " + item.ProductNameInf + " стоимостью " + item.ProductPriceInf + "$");
            }

        }

    }
}
