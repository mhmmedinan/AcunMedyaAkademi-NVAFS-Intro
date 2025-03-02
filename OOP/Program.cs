using OOP;

Product product = new Product();
product.Id = 1;
product.Name = "Laptop";
product.UnitPrice = 5000;


Product product2 = new Product();
product2.Id = 1;
product2.Name = "Laptop";
product2.UnitPrice = 5000;
product.SetProductId(5);
product.ProductName = null;

Console.WriteLine(product.Name); //false
Console.WriteLine(product.GetProductId()); //true
//product.ProductId = 2; //false
Console.WriteLine(product.ProductName); //true


Category category = new Category();
category.Id = 1;
category.Name = "İletişim";
category.CreatedDate = DateTime.Now;
category.UpdatedDate = DateTime.Now;
category.DeletedDate = DateTime.Now;

CategoryManager categoryManager = new CategoryManager();
categoryManager.Add(category);

List<Category> categories = categoryManager.GetCategories();
foreach (var item in categories)
{
    Console.WriteLine(item.Name);
}




