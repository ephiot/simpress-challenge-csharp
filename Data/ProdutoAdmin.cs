using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using simpress_challenge.Models;

namespace simpress_challenge.Data
{
    public class ProdutoAdmin
    {
        /// <summary>Get all products</summary>
        /// <returns>products data as list</returns>
        public IEnumerable<tblProduto> Get()
        {
            using (PRODUTOSTOREEntities context = new PRODUTOSTOREEntities())
            {
                return context.tblProduto.Include("tblCategoriaProduto").ToList();
            }
        }

        /// <summary>Store a product category on database</summary>
        /// <param name="data">Product category data</param>
        public void Store(tblProduto data)
        {
            using (PRODUTOSTOREEntities context = new PRODUTOSTOREEntities())
            {
                context.tblProduto.Add(data);
                context.SaveChanges();
            }
        }

        /// <summary>Return a product category</summary>
        /// <param name="id"></param>
        /// <returns>Product category data</returns>
        public tblProduto Show(int id)
        {
            using (PRODUTOSTOREEntities context = new PRODUTOSTOREEntities())
            {
                return context.tblProduto.Include("tblCategoriaProduto").FirstOrDefault(v => v.Id == id);
            }
        }

        /// <summary>
        /// Edit a product category
        /// </summary>
        /// <param name="data"></param>
        public void Update(tblProduto data)
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
        public void Delete(tblProduto data)
        {
            using (PRODUTOSTOREEntities context = new PRODUTOSTOREEntities())
            {
                context.Entry(data).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}