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
            bool flagForExit = false;
            List<ProductInfo> myOrderList = new List<ProductInfo>();
            (string ProdType, string ProdName, double ProdPrice, int NumOfProd) ProdTuple = default;

            ShopProduct products = new ShopProduct("Книга", "\"Большая энциклопедия\"", 5.99, 3);
            ShopProduct products2 = new ShopProduct("Книга", "Герберт Шилдт \"C# 4.0: полное руководство\"", 8.89, 1);
            ShopProduct products3 = new ShopProduct("Игрушка", "модель легкового автомобиля \"Ford Focus\"", 4.79, 2);
            ShopProduct products4 = new ShopProduct("Игрушка", "кукла \"Barbie\"", 5.49, 1);

            SaleProduct saleProduct = new SaleProduct();

            ShopItem book1 = new ShopItem(products, 1);
            ShopItem book2 = new ShopItem(products2, 2);
            ShopItem toy1 = new ShopItem(products3, 3);
            ShopItem toy2 = new ShopItem(products4, 4);
            Console.WriteLine("На данный момент у нас имеются в наличии следующие товары:");
            book1.ShowProduct();
            book2.ShowProduct();
            toy1.ShowProduct();
            toy2.ShowProduct();
            saleProduct.ShowProducts(5);

            while (!flagForExit)
            {
                Console.WriteLine("\nУкажите номер товара, который хотите выбрать или добавить в корзину.\n(Чтобы выйти напишите: Выход)");
                var userEnter = Console.ReadLine();
                if (int.TryParse(userEnter, out int numberSelectedProduct) && numberSelectedProduct > 0 && numberSelectedProduct < 6)
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
                        case 5:
                            saleProduct.GetSaleProduct(ref ProdTuple);
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
        private void GetProducts(ShopProduct productsAdd, ref (string ProdType, string ProdName, double ProdPrice, int NumOfProd) prodTuple)
        {
            prodTuple.ProdType = productsAdd.ProductType;
            prodTuple.ProdName = productsAdd.ProductName;
            prodTuple.ProdPrice = productsAdd.ProductPrice;
            prodTuple.NumOfProd = 1;
        }
        public ProductInfo GetProductsToList((string ProdType, string ProdName, double ProdPrice, int NumOfProd) prodTupleToList, out ProductInfo productInfoList)
        {
            ProductInfo productInfo = new ProductInfo
            {
                ProductTypeInf = prodTupleToList.ProdType,
                ProductNameInf = prodTupleToList.ProdName,
                ProductPriceInf = prodTupleToList.ProdPrice,
                NumberOfProductsInf = prodTupleToList.NumOfProd
            };
            productInfoList = productInfo;
            return productInfoList;
        }
        public void ShowMyOrder(List<ProductInfo> orderList)
        {
            double summPrice = 0;
            foreach (var item in orderList)
            {
                Console.WriteLine(item.ProductTypeInf + " " + "1 шт. " + item.ProductNameInf + " стоимостью " + item.ProductPriceInf + "$");
                summPrice += item.ProductPriceInf;
            }
            Console.WriteLine("Общая стоимость: " + summPrice);
        }
    }
}
