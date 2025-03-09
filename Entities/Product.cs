using Core.Entities;

namespace Entities;

public class Product:BaseEntity<Guid>
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public Category Category { get; set; }

    public Product()
    {
        
    }

    public Product(Guid id, string name, decimal price, string description, Category category)
    {
        Id = id;
        Name = name;
        Price = price;
        Description = description;
        Category = category;
    }
}
