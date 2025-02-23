// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Veriables

//camelCase // değişken isimleri ingilizce
string productName = "Casper Excalibur G770";


byte unitInStock = 5;  // 0-255
short unitInStock1 = 10;  // 32767
int unitInStock2 = 20; // 2 milyar küsür 
long unitInStock3 = 30;


double unitPrice = 59.99;
decimal unitPrice1 = 59.99M;
float unitPrice2 = 59.99F;


// ondalıklı veri tipine tam sayı atanabilir ama tam sayı veri tipine ondalıklı atanamaz ve convert edilemez.

//double number = 5;
//int number1 = 5.9;

char gender = 'K';

//bool isLogin = true or false;
int x = 5;
int y = 10;

y = x;
x = y;
Console.WriteLine(x);



//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);


//Conditials

string correctUsername = "mehmetemin";
string correctPassword = "123456";

//Console.Write("Enter Username : ");
//string username = Console.ReadLine();

//Console.Write("Enter Password : ");
//string password = Console.ReadLine();


//if (username == correctUsername && password == correctPassword)
//    Console.WriteLine("Login Successful!");
//else
//{
//    Console.WriteLine("Username or password dont match!");
//}




//Console.WriteLine("Restaurant Menu");
//Console.WriteLine("1-Hamburger");
//Console.WriteLine("2-Pizza");
//Console.WriteLine("3-Salad");
//Console.Write("Enter your choice (1-3) : ");
//double userInput = Convert.ToDouble(Console.ReadLine());
//int choice = (int)Math.Round(userInput);


//if (choice == 1) 
//{
//    Console.WriteLine("Hamburger Ordered");
//}
//else if (choice == 2)
//{
//    Console.WriteLine("Pizza ordered");
//}
//else if (choice == 3)
//{
//    Console.WriteLine("Salad Ordered");
//}
//else
//{
//    Console.WriteLine("Invalid menu choice!");
//}




//Console.Write("Enter your role (admin/user) : ");
//string role = Console.ReadLine().ToLower();

//bool isAdmin = (role == "admin");
//if (isAdmin)
//    Console.WriteLine("Access granted. Welcome!");
//else
//    Console.WriteLine("Access denied!");





//Loops

//for,while,foreach,do-while

for(int i = 0; i<20; i++)
{
    Console.WriteLine(i);
}


for(int i = 0; i < 25; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine($" Tek Sayılar : {i}");
    }
}


//diziler sabit boyutludur.
//string[] products = new string[3];
//products[0] = "Laptop";
//products[1] = "Mouse";
//products[2] = "Keyboard";


//for(int i = 0; i < products.Length; i++)
//{
//    Console.WriteLine($"Ürünler : {products[i]}");
//}

//string[] products = { "Laptop", "Mouse", "Keyboard" };
//products[3] = "Monitor";                    // dizinin boyutunu aştığı için hata verir.
//foreach(string product in products)
//{
//     Console.WriteLine($"Ürünler : {product}");
//}


//Console.Write("Dizi boyutunu giriniz : ");
//int arraySize = Convert.ToInt32(Console.ReadLine());

//int[] numbers = new int[arraySize];
//for(int i = 0; i < arraySize; i++)
//{
//    Console.Write("Sayı giriniz : ");
//    numbers[i] = Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("Girilen Sayılar : ");
//foreach(int number in numbers)
//{
//    Console.WriteLine(number);
//}


//list
//<T> generic yapıdır. T herhangi bir veri tipi olabilir.
//List<string> cities = new List<string>();
//cities.Add("Ankara");
//cities.Add("İstanbul");
//cities.Add("İzmir");

//foreach(string city in cities)
//{
//    Console.WriteLine(city);
//}

//Console.WriteLine("-------------------------");

//cities.Add("Adana");
//foreach (string city in cities)
//{
//    Console.WriteLine(city);
//}

//Console.WriteLine("-------------------------");
//cities.Remove("Ankara");
//foreach (string city in cities)
//{
//    Console.WriteLine(city);
//}


List<string> cities = new List<string> {"Ankara", "İstanbul", "İzmir","Ankara"};
foreach (string city in cities)
{
    Console.WriteLine(city);
}
cities.RemoveAll(city=>city == "Ankara");

Console.WriteLine("-------------------------");
foreach (string city in cities)
{
    Console.WriteLine(city);
}


List<string> baskets = new List<string> { "Apple", "Banana", "Orange", "Apple" };

foreach (string basket in baskets)
{
    Console.WriteLine(basket);
}

Console.Write("Silmek istediğiniz ürünü giriniz : ");
string product = Console.ReadLine();

if (baskets.Contains(product))
{
    baskets.Remove(product);
    Console.WriteLine($" {product} isimli ürün sepetten silindi.");
}
else
{
    Console.WriteLine($" {product} isimli ürün sepetinizde bulunamadı.");
}

Console.WriteLine("Sepetinizdeki ürünler : ");
foreach (string basket in baskets)
{
    Console.WriteLine(basket);
}

