namespace OOP;

public class Category:BaseEntity<short>
{
    public string Name { get; set; }

    public Category(short id,string name)
    {
        Id = id;
        Name = name;
    }

    public Category()
    {
        CreatedDate = DateTime.Now;
    }
}
