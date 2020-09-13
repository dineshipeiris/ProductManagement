using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManagement.Repository
{
    public static class ProductList
    {
        static List<Product> productList = null;

        static ProductList()
        {
            productList = new List<Product>()
            {
                new Product()
                {
                    ProductItemCode = 1,
                    Name = "ESS Washing Liquid - 1l",
                    UnitPrice = 10.00m,
                }
            };
        }

        public static List<Product> SelectProductLIst()
        {
            return productList;
        }

        public static void InsertProductList(Product Product)
        {
            productList.Add(Product);
        }

        public static void UpdateProductList(Product Product)
        {
            Product productUpdate = productList.Find(x => x.ProductItemCode == Product.ProductItemCode);
            productUpdate.Name = Product.Name;
            productUpdate.UnitPrice = Product.UnitPrice;
        }

        public static void DeleteProductList(int id)
        {
            Product employeeDelete = productList.Find(x => x.ProductItemCode == id);
            productList.Remove(employeeDelete);
        }
    }
}