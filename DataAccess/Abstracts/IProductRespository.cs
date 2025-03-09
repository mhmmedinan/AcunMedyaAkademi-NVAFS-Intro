using Entities;

namespace DataAccess.Abstracts;

public interface IProductRespository
{
    void Add(Product product);
    List<Product> GetAll();
}
