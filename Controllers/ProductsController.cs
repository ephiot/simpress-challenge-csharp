using simpress_challenge.Data;
using simpress_challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace simpress_challenge.Controllers
{
    public class ProductsController : Controller
    {
        ProdutoAdmin admin = new ProdutoAdmin();
        CategoriaProdutoAdmin categoriaAdmin = new CategoriaProdutoAdmin();

        // GET: Products
        public ActionResult Index(string message = "")
        {
            IEnumerable<tblProduto> list = admin.Get();
            ViewBag.message = message;
            return View("Index", list);
        }

        // Create: Products
        public ActionResult Create(string message = "", tblProduto data = null)
        {
            SelectList categories = new SelectList(
                categoriaAdmin.Get(),
                "Id",
                "Nome"
            );

            ViewBag.categories = categories;
            ViewBag.message = message;
            return View("Create", data);
        }

        // Store: Products
        public ActionResult Store(tblProduto data)
        {

            admin.Store(data);
            return this.Create("Product stored!", data);
        }

        // Show: Products
        public ActionResult Show(int id = 0)
        {
            tblProduto data = admin.Show(id);
            SelectList categories = new SelectList(
                categoriaAdmin.Get(),
                "Id",
                "Nome"
            );

            ViewBag.categories = categories;
            return View("Show", data);
        }

        // Edit: Products
        public ActionResult Edit(int id = 0, string message = "")
        {
            tblProduto data = admin.Show(id);
            SelectList categories = new SelectList(
                categoriaAdmin.Get(),
                "Id",
                "Nome",
                data.Id
            );

            ViewBag.categories = categories;
            ViewBag.message = message;
            return View("Edit", data);
        }

        // Update: Products
        public ActionResult Update(tblProduto data)
        {
            admin.Update(data);
            return this.Edit(data.Id, "Product updated!");
        }

        // Delete: Products
        public ActionResult Delete(int id = 0)
        {
            tblProduto data = new tblProduto()
            {
                Id = id
            };
            admin.Delete(data);
            return this.Index("Product deleted!");
        }
    }
}