using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7._7.Practice
{
    class Products
    {
        protected internal string TypeProduct;
        protected internal double ProductPrice;
        public int NumberOfProducts;

        public void GetProduct(string typeProduct, double productPrice, int numberOfProducts)
        {
            TypeProduct = typeProduct;
            ProductPrice = productPrice;
            NumberOfProducts = numberOfProducts;
        }
    }

    class Book
    {
        private Products products;
        public Book(Products aProducts)
        {
            products = aProducts;
        }
        public void GetBook(string typeProduct, double productPrice, int numberOfProducts)
        {
            products.GetProduct(typeProduct, productPrice, numberOfProducts);
            Console.WriteLine(products.NumberOfProducts + " " + products.TypeProduct + " стоимостью " + products.ProductPrice + "$");
        }
    }

}
