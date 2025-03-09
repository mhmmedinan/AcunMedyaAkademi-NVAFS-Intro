using Business.Abstracts;
using Core.Logger;
using DataAccess.Abstracts;
using Entities;

namespace Business.Concretes;

public class ProductManager:IProductService
{
    //private readonly InMemoryProductRepository _inmemoryRepository;
    //private readonly EfProductRepository _efRepository;

    //public ProductManager(InMemoryProductRepository inmemoryRepository, EfProductRepository efRepository)
    //{
    //    _inmemoryRepository = inmemoryRepository;
    //    _efRepository = efRepository;
    //}

    private readonly IProductRespository _repository;
    private readonly ILogger _logger;

    public ProductManager(IProductRespository repository, ILogger logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public void Add(Product product)
    {
        _logger.Log(product.Name);

        if (product.Price < 0)
        {
            throw new Exception("Price cannot be less than 0");
        }
        //_inmemoryRepository.Add(product);
        //_efRepository.Add(product);
        _repository.Add(product);
    }

    public List<Product> GetProducts()
    {
        _logger.Log("Products are fetched");
        //return _inmemoryRepository.GetAll();
        return _repository.GetAll();
    }
}
