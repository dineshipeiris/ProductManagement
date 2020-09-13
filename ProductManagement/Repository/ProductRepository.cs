using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManagement.Repository
{
    public class ProductRepository : IProductRepository
    {
        public List<Models.Product> SelectAllProducts()
        {
            return ProductList.SelectProductLIst();
        }

        public Models.Product SelectProductById(int id)
        {
            return ProductList.SelectProductLIst().Find(x => x.ProductItemCode == id);
        }

        public void InsertProduct(Models.Product Product)
        {
            ProductList.InsertProductList(Product);
        }

        public void UpdateProduct(Models.Product Product)
        {
            ProductList.UpdateProductList(Product);
        }

        public void DeleteProduct(int id)
        {
            ProductList.DeleteProductList(id);
        }
    }
}