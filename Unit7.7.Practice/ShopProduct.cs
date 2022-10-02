using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7._7.Practice
{
    class ShopProduct
    {
        protected internal string ProductType;
        protected internal string ProductName;
        protected internal double ProductPrice;
        public int NumberOfProducts;

        public ShopProduct(string typeProduct, string productName, double productPrice, int numberOfProducts)
        {
            ProductType = typeProduct;
            ProductName = productName;
            ProductPrice = productPrice;
            NumberOfProducts = numberOfProducts;
        }

        public void ShowProducts()
        {
            if (NumberOfProducts == 1)
            {
                Console.WriteLine(ProductType + " (" + NumberOfProducts + " шт.), " + ProductName + " стоимостью " + ProductPrice + "$");
            }
            else if (NumberOfProducts > 0)
            {
                Console.WriteLine(ProductType + " (" + NumberOfProducts + " шт.), " + ProductName + " стоимостью " + ProductPrice + "$ за штуку");
            }
        }
    }

    class SaleProduct
    {
        private ShopProduct shopProduct = new ShopProduct("Чай", "\"Lipton\" (25 пакетиков)", 0.99, 5);
        public void ShowProducts(int productSaleId)
        {
            Console.WriteLine("ВНИМАНИЕ! % Специальная цена %\nНомер - {0}:", productSaleId);
            shopProduct.ShowProducts();
        }
        public void GetSaleProduct(ref (string ProdType, string ProdName, double ProdPrice, int NumOfProd) prodTuple)
        {
            prodTuple.NumOfProd = 1;
            prodTuple.ProdName = shopProduct.ProductName;
            prodTuple.ProdPrice = shopProduct.ProductPrice;
            prodTuple.ProdType = shopProduct.ProductType;
        }
    }

    class ShopItem
    {
        protected internal int ProductId;
        private readonly ShopProduct products;

        public ShopItem(ShopProduct aProducts, int productId)
        {
            products = aProducts;
            ProductId = productId;
        }

        public void ShowProduct()
        {
            Console.WriteLine("Номер - {0}:", ProductId);
            products.ShowProducts();
        }
    }
     class ProductInfo
    {
        public string ProductTypeInf { get; set; }
        public string ProductNameInf { get; set; }
        public double ProductPriceInf { get; set; }
        public int NumberOfProductsInf { get; set; }
    }
}
