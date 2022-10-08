using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>() { 
            new Product{CategoryID=1,ProductID=1,ProductName="bardak",
            UnitPrice=15,UnitInStock=15},
            new Product{CategoryID=1,ProductID=2,ProductName="kamera",
            UnitPrice=500,UnitInStock=3},
                new Product{CategoryID=2,ProductID=3,ProductName="telefon",
            UnitPrice=1500,UnitInStock=2},
                new Product{CategoryID=2,ProductID=4,ProductName="klavye",
            UnitPrice=150,UnitInStock=65},
                new Product{CategoryID=2,ProductID=5,ProductName="fare",
            UnitPrice=85,UnitInStock=1}
            };
        }
        public void Add(Product product)
        {
        _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            _products.Remove(productToDelete);

            //foreach (var p in _products)
            //{
            //    if (product.ProductID == p.ProductID)
            //    {
            //        productToDelete = p;
            //    }
            //}
            //_products.Remove(productToDelete);


        }

        public List<Product> GetAll()
        {
        return _products;
        }

        public List<Product> GetAllByCategory(int categoryID)
        {
           return _products.Where(p => p.CategoryID == categoryID).ToList();   
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
            productToUpdate.CategoryID = product.CategoryID;

        }
    }
}
