using Slab.Net.EF.Entities;
using Slab.Net.EF.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slab.Net.EF.Logic
{
    public class ProductsLogic : BaseLogic<Products, int>
    {
        public override int Add(Products newItem)
        {
            //FALTARIAN CHEQUEOS
            db.Products.Add(newItem);
            db.SaveChanges();
            return newItem.ProductID;
        }

        public override Products Get(int id) => db.Products.Find(id);

        public override List<Products> GetAll() => db.Products.ToList();
        

        public override void Remove(int toDeleteId)
        {
            Products toRemove = db.Products.Find(toDeleteId);
            if (toRemove == null)
                throw new NullReferenceException();
            db.Products.Remove(toRemove);
            db.SaveChanges();
        }

        public override void Update(Products toUpdate)
        {
            Products product = db.Products.Find(toUpdate.ProductID);
            if (product == null)
                throw new NullReferenceException();
            product.ReorderLevel = toUpdate.ReorderLevel;
            product.Suppliers = toUpdate.Suppliers;
            product.UnitPrice = toUpdate.UnitPrice;
            product.QuantityPerUnit = toUpdate.QuantityPerUnit;
            //ETC
            db.SaveChanges();
        }

        // 2. Query para devolver todos los productos sin stock
        public IQueryable<Products> ListNonStockMS()
        {
            return db.Products.Where(p => p.UnitsInStock == 0).Select(p => p);
        }

        public IQueryable<Products> ListNonStockQS()
        {
            return from product in db.Products
                where product.UnitsInStock == 0
                select product;
        }

        //3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad
        public IQueryable<Products> ListWithStockAndUnitPriceGreatherMS(decimal price)
        {
            return db.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > price).Select(p => p);
        }
        public IQueryable<Products> ListWithStockAndUnitPriceGreatherQS(decimal price)
        {
            return from product in db.Products
                 where product.UnitsInStock > 0
                 where product.UnitPrice > price
                 select product;
        }

        //5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789(Parametrizado)
        public Products GetFirstProductByIdMS(int id)
        {
            return db.Products.Where(p => p.ProductID == id).FirstOrDefault();
        }

        public Products GetFirstProductByIdQS(int id)
        {
            return (from product in db.Products
                    where product.ProductID == id
                    select product).FirstOrDefault();
        }

        // 9. Query para devolver lista de productos ordenados por nombre
        public IQueryable<Products> ListOrderByNameMS() {
            return db.Products.OrderBy(p => p.ProductName).Select(p => p);
        }

        public IQueryable<Products> ListOrderByNameQS()
        {
            return from product in db.Products
                   orderby product.ProductName ascending
                   select product;
        }


        // 10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.
        public IQueryable<Products> ListOrderByInStockMS()
        {
            return db.Products.OrderByDescending(p => p.UnitsInStock).Select(p => p);
        }

        public IQueryable<Products> ListOrderByInStockQS()
        {
            return from product in db.Products
                   orderby product.UnitsInStock descending
                   select product;
        }

        //11. Query para devolver las distintas categorías asociadas a los productos
        public IQueryable<CategoriesDTO> ListDistinctCategoriesMS()
        {
            return db.Products.Join(db.Categories,
                p => p.CategoryID,
                c => c.CategoryID,
                (p, c) => c).Select( c => new CategoriesDTO
                {
                    CategoryID = c.CategoryID, 
                    CategoryName = c.CategoryName, 
                    Description = c.Description,
                }).Distinct();
        }

        public IQueryable<CategoriesDTO> ListDistinctCategoriesQS()
        {
            return (from product in db.Products
                   join categorie in db.Categories
                   on product.CategoryID equals categorie.CategoryID
                   select new CategoriesDTO
                   {
                       CategoryID = categorie.CategoryID,   
                       CategoryName = categorie.CategoryName,
                       Description = categorie.Description,
                   }).Distinct();
        }

        // 12. Query para devolver el primer elemento de una lista de productos
        public Products GetFirstMS()
        {
            return db.Products.FirstOrDefault();
        }

        public Products GetFirstQS()
        {
            return (from product in db.Products
                   select product).FirstOrDefault();
        }

    }
}
