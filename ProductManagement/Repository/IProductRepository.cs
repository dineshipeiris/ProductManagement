using ProductManagement.Models;
using System.Collections.Generic;

namespace ProductManagement.Repository
{
    public interface IProductRepository
    {
        void DeleteProduct(int id);
        void InsertProduct(Product Product);
        List<Product> SelectAllProducts();
        Product SelectProductById(int id);
        void UpdateProduct(Product Product);
    }
}