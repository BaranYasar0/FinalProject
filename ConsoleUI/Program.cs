// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;


ProductManager productManager = new ProductManager(new EfProductDal());
foreach (var item in productManager.GetByUnitPrice(10,200))
{
    Console.WriteLine(item.ProductName);
}
