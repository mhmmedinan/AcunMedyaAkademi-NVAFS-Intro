namespace OOP;

public class Product:BaseEntity<int>
{
    //Property isimleri PascalCase olmalıdır.
    public int Id { get; set; }
    public string Name { get; set; }
    public double UnitPrice { get; set; }



    //Encapsulation => Bir nesnenin alanlarını ve metotlarını bir arada tutarak, nesnenin kendi içindeki işleyişini gizlemek ve dışarıdan erişime kapamak anlamına gelir.

    //1.Kullanım 
    //public int ProductId { get; }


    //2. Kullanım

    private int ProductId { get; set; }

    public void SetProductId(int productId)
    {
       ProductId = productId;
    }

    public int GetProductId()
    {
        return ProductId;
    }


    //3. Kullanım

    private string name;

    public string ProductName
    {
        get { return name; }
        set {
            if(!string.IsNullOrEmpty(value))
                name = value;
            else
                Console.WriteLine("Ürün ismi boş olamaz.");
        }
    }

}


//internal => Ayarlanan erişim belirleyicisi, yalnızca içinde bulunduğu derleme içerisinde erişilebilir.
//private => Ayarlanan erişim belirleyicisi, yalnızca içinde bulunduğu sınıf içerisinde erişilebilir.
//protected => Ayarlanan erişim belirleyicisi, yalnızca içinde bulunduğu sınıf ve bu sınıftan türetilen sınıflar içerisinde erişilebilir.
//public => Ayarlanan erişim belirleyicisi, her yerden erişilebilir.