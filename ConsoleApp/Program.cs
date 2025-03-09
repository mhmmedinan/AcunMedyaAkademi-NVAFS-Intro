// See https://aka.ms/new-console-template for more information
using Business.Abstracts;
using Business.Concretes;
using Core.Logger;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;
using Entities;

Console.WriteLine("Hello, World!");

                                                     //Polymorfizm
IProductService productService = new ProductManager(new EfProductRepository(),new FileLogger());
productService.Add(new Product(Guid.NewGuid(), "Iphone 13", 1100, "Apple Iphone 13", new Category(1, "Smartphone")));

List<Product> products = productService.GetProducts();
foreach (var product in products)
{
    Console.WriteLine(product.Name);
}
