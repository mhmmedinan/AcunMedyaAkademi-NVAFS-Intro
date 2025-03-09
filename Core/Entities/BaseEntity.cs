namespace Core.Entities;

public abstract class BaseEntity<TId>
{
    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime DeletedDate { get; set; }

    protected BaseEntity(TId id, DateTime createdDate, DateTime updatedDate, DateTime deletedDate)
    {
        Id = id;
        CreatedDate = createdDate;
        UpdatedDate = updatedDate;
        DeletedDate = deletedDate;
    }

    protected BaseEntity()
    {

    }
}