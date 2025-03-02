namespace OOP;

public class CategoryManager
{

    private List<Category> _categories;


    //Constructor (Yapıcı) => Bir sınıf new'lendiğinde çalışan metot.
    public CategoryManager()
    {
        //Dependency Injection
        //Singleton Pattern
        _categories = new List<Category>();
    }

    public void Add(Category category)
    {
        category.CreatedDate = DateTime.Now;
        _categories.Add(category);
    }

    public List<Category> GetCategories()
    {
        
        return _categories;
    }
}





//Customer => Müşteri 
//Individual ve Corporate Customer sınıfları oluşturunuz.
//IndividualCustomerManaager adında bir sınıf oluşturunuz.
// Add,Delete,GetAll,GetById metotlarını ekleyiniz.