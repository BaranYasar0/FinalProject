using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
//foreach (var category in)
//{
    //Console.WriteLine(categoryManager.GetById(2));
  //  Console.WriteLine("Category Name is " + category.CategoryName);
//}









//CategoryTest();
//ProductTest();

//static void ProductTest()
//{
//    ProductManager productManager = new ProductManager(new EfProductDal());
//    var result = productManager.GetProductDetails();

//    if (DateTime.Now.Hour==18)
//    {
//        Console.WriteLine(result.Message);
//    }
//    else
//    {
//        foreach (var item in result.Data)
//        {
//            Console.WriteLine(item.ProductName + "/" + item.CategoryName);
//        }
//    }

//}

//static void CategoryTest()
//{
//    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
//    foreach (var category in categoryManager.GetAll())
//    {
//        Console.WriteLine(categoryManager.GetById(2)); 
//        Console.WriteLine("Category Name is " + category.CategoryName);
//    }
//}