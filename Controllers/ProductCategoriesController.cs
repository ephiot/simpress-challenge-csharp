using simpress_challenge.Data;
using simpress_challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace simpress_challenge.Controllers
{
    public class ProductCategoriesController : Controller
    {
        CategoriaProdutoAdmin admin = new CategoriaProdutoAdmin();

        // GET: ProductCategories
        public ActionResult Index(string message = "")
        {
            IEnumerable<tblCategoriaProduto> list = admin.Get();
            ViewBag.message = message;
            return View("Index", list);
        }

        // Create: ProductCategories
        public ActionResult Create(string message = "", tblCategoriaProduto data = null)
        {
            ViewBag.message = message;
            return View("Create", data);
        }

        // Store: ProductCategories
        public ActionResult Store(tblCategoriaProduto data)
        {
            admin.Store(data);
            return this.Create("Product category stored!", data);
        }

        // Show: ProductCategories
        public ActionResult Show(int id = 0)
        {
            tblCategoriaProduto data = admin.Show(id);
            return View("Show", data);
        }

        // Edit: ProductCategories
        public ActionResult Edit(int id = 0, string message = "")
        {
            tblCategoriaProduto data = admin.Show(id);
            ViewBag.message = message;
            return View("Edit", data);
        }

        // Update: ProductCategories
        public ActionResult Update(tblCategoriaProduto data)
        {
            admin.Update(data);
            return this.Edit(data.Id, "Product category updated!");
        }

        // Delete: ProductCategories
        public ActionResult Delete(int id = 0)
        {
            tblCategoriaProduto data = new tblCategoriaProduto()
            {
                Id = id
            };
            admin.Delete(data);
            return this.Index("Product category deleted!");
        }
    }
}