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

        public List<ProductInfo> productInfos = new List<ProductInfo>();

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
        public void GetProducts()
        {
            ProductInfo productInfo = new ProductInfo();
            productInfo.ProductTypeInf = ProductType;
            productInfo.ProductNameInf = ProductName;
            productInfo.ProductPriceInf = ProductPrice;
            productInfo.NumberOfProductsInf = NumberOfProducts;
            productInfos.Add(productInfo);
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
        public void GetProduct()
        {
            products.GetProducts();
            products.NumberOfProducts = 1;
            //foreach (var item in products.productInfos)
            //{
            //    Console.WriteLine(item.ProductTypeInf + " " + products.NumberOfProducts + " шт. " + item.ProductNameInf + " стоимостью " + item.ProductPriceInf + "$");
            //}

        }
    }
    class ProductInfo
    {
        public string ProductTypeInf { get; set; }
        public string ProductNameInf { get; set; }
        public double ProductPriceInf { get; set; }
        public int NumberOfProductsInf { get; set; }

        //private string _productType;
        //public string ProductType
        //{
        //    get
        //    {
        //        return _productType;
        //    }
        //    set
        //    {
        //        _productType = value;
        //    }
        //}
        //private string _productName;
        //public string ProductName
        //{
        //    get
        //    {
        //        return _productName;
        //    }
        //    set
        //    {
        //        _productName = value;
        //    }
        //}
        //private double _productPrice;
        //public double ProductPrice
        //{
        //    get
        //    {
        //        return _productPrice;
        //    }
        //    set
        //    {
        //        _productPrice = value;
        //    }
        //}
        //private int _numberOfProducts;
        //public int NumberOfProducts
        //{
        //    get
        //    {
        //        return _numberOfProducts;
        //    }
        //    set
        //    {
        //        _numberOfProducts = value;
        //    }
        //}
    }
}
