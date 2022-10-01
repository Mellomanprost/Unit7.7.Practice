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

        public void GetProducts(string typeProduct, string productName, double productPrice, int numberOfProducts)
        {
            ProductType = typeProduct;
            ProductName = productName;
            ProductPrice = productPrice;
            NumberOfProducts = numberOfProducts;
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
        public List<ProductInfo> productInfos = new List<ProductInfo>();
        public void ShowProduct(string typeProduct, string productName, double productPrice, int numberOfProducts)
        {
            products.GetProducts(typeProduct, productName, productPrice, numberOfProducts);
            Console.WriteLine("Под номером - {0}", ProductId);
            if (numberOfProducts == 1)
            {
                Console.WriteLine(products.ProductType + " - " + products.NumberOfProducts + " шт., " + products.ProductName + " стоимостью " + products.ProductPrice + "$");
            }
            else if(numberOfProducts > 0)
            {
                Console.WriteLine(products.ProductType + " - " + products.NumberOfProducts + " шт., " + products.ProductName + " стоимостью " + products.ProductPrice + "$ за штуку");
            }
        }
        public void GetProduct(string typeProduct, string productName, double productPrice, int numberOfProducts)
        {
            products.GetProducts(typeProduct, productName, productPrice, numberOfProducts);
            if (numberOfProducts == 1)
            {
                Console.WriteLine(products.ProductType + " - " + products.NumberOfProducts + " шт. " + products.ProductName + " стоимостью " + products.ProductPrice + "$");
            }
            else if (numberOfProducts > 0)
            {
                Console.WriteLine(products.ProductType + " - " + products.NumberOfProducts + " шт. " + products.ProductName + " общей стоимостью " + products.ProductPrice * products.NumberOfProducts + "$");
            }

        }
    }
    class ProductInfo
    {
        private string _productType;
        public string ProductType
        {
            get
            {
                return _productType;
            }
            set
            {
                _productType = value;
            }
        }
        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
            }
        }
        private double _productPrice;
        public double ProductPrice
        {
            get
            {
                return _productPrice;
            }
            set
            {
                _productPrice = value;
            }
        }
        private int _numberOfProducts;
        public int NumberOfProducts
        {
            get
            {
                return _numberOfProducts;
            }
            set
            {
                _numberOfProducts = value;
            }
        }
    }
}
