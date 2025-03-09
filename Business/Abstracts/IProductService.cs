using Entities;

namespace Business.Abstracts;

public interface IProductService
{
    void Add(Product product);
    List<Product> GetProducts();
}
