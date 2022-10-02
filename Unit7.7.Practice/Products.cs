using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7._7.Practice
{
    class Products
    {
        protected internal string ProductType;
        protected internal string ProductName;
        protected internal double ProductPrice;
        public int NumberOfProducts;

        public Products(string typeProduct, string productName, double productPrice, int numberOfProducts)
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
                Console.WriteLine(ProductType + " - " + NumberOfProducts + " шт., " + ProductName + " стоимостью " + ProductPrice + "$");
            }
            else if (NumberOfProducts > 0)
            {
                Console.WriteLine(ProductType + " - " + NumberOfProducts + " шт., " + ProductName + " стоимостью " + ProductPrice + "$ за штуку");
            }
        }
    }

    class Product
    {
        protected internal int ProductId;
        private Products products;

        public Product(Products aProducts, int productId)
        {
            products = aProducts;
            ProductId = productId;
        }

        public void ShowProduct()
        {
            Console.WriteLine("Под номером - {0}", ProductId);
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
