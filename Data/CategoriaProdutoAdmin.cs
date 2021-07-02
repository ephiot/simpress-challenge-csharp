using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using simpress_challenge.Models;

namespace simpress_challenge.Data
{
    public class CategoriaProdutoAdmin
    {
        /// <summary>Get all product categories</summary>
        /// <returns>Product categories data as list</returns>
        public IEnumerable<tblCategoriaProduto> Get()
        {
            using (PRODUTOSTOREEntities context = new PRODUTOSTOREEntities())
            {
                return context.tblCategoriaProduto.ToList();
            }
        }

        /// <summary>Store a product category on database</summary>
        /// <param name="data">Product category data</param>
        public void Store(tblCategoriaProduto data)
        {
            using (PRODUTOSTOREEntities context = new PRODUTOSTOREEntities())
            {
                context.tblCategoriaProduto.Add(data);
                context.SaveChanges();
            }
        }

        /// <summary>Return a product category</summary>
        /// <param name="id"></param>
        /// <returns>Product category data</returns>
        public tblCategoriaProduto Show(int id)
        {
            using (PRODUTOSTOREEntities context = new PRODUTOSTOREEntities())
            {
                return context.tblCategoriaProduto.FirstOrDefault(v => v.Id == id);
            }
        }

        /// <summary>
        /// Edit a product category
        /// </summary>
        /// <param name="data"></param>
        public void Update(tblCategoriaProduto data)
        {
            using (PRODUTOSTOREEntities context = new PRODUTOSTOREEntities())
            {
                context.Entry(data).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Delete a product category
        /// </summary>
        /// <param name="data"></param>
        public void Delete(tblCategoriaProduto data)
        {
            using (PRODUTOSTOREEntities context = new PRODUTOSTOREEntities())
            {
                context.Entry(data).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}