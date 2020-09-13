using ProductManagement.Models;
using ProductManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductManagement.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository repository = new ProductRepository();

        /// <summary>
        /// Get: /Product/
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            IEnumerable<Product> ProductList = repository.SelectAllProducts();
            return View(ProductList);
        }

        /// <summary>
        /// GET: /Product/Details/1
        /// </summary>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            Product Product = repository.SelectProductById(id);

            return View(Product);
        }

        /// <summary>
        /// GET: /Product/Create
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// POST: /Product/Create
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if(ModelState.IsValid)
            {
                repository.InsertProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        /// <summary>
        /// GET: /Product/Edit/1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Product product = repository.SelectProductById(id);
            return View(product);
        }

        /// <summary>
        /// POST: /Product/Edit/1
        /// </summary>
        /// <param name="id"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            if (ModelState.IsValid)
            {
                repository.UpdateProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        /// <summary>
        /// GET: /Product/Delete/1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Product Product = repository.SelectProductById(id);
            return View(Product);
        }

        /// <summary>
        /// POST: /Product/Delete/1
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                repository.DeleteProduct(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}