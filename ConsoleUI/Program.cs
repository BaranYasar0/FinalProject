// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

Console.WriteLine("Hello, World!");

ProductManager productManager = new ProductManager(new InMemoryProductDal());
InMemoryProductDal productDal = new InMemoryProductDal();
foreach (var item in productManager.GetAll())
{
    Console.WriteLine(item.ProductName);
}
