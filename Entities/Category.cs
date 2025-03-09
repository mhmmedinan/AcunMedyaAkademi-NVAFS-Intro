using Core.Entities;

namespace Entities;

public class Category:BaseEntity<int>
{
    public string Name { get; set; }

    public Category()
    {
        
    }

    public Category(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
