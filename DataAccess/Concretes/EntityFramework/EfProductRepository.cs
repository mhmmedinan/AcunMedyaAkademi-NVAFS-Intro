using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes.EntityFramework;

public class EfProductRepository:IProductRespository
{
    private List<Product> _products;

    public EfProductRepository()
    {
        _products = new List<Product>();

        //Seed data

        _products.Add(new Product(Guid.NewGuid(), "Iphone 12", 1000, "Apple Iphone 12", new Category(1, "Smartphone")));
        _products.Add(new Product(Guid.NewGuid(), "Samsung S21", 900, "Samsung S21", new Category(1, "Smartphone")));
        _products.Add(new Product(Guid.NewGuid(), "Samsung S20", 800, "Samsung S20", new Category(1, "Smartphone")));
    }


    public void Add(Product product)
    {
        Console.WriteLine("Adding product to ef core");
        _products.Add(product);
    }


    public List<Product> GetAll()
    {
        Console.WriteLine("Getting all products from ef core");
        return _products;
    }
}
