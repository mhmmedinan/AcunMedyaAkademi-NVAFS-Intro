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




Console.Write("Enter your role (admin/user) : ");
string role = Console.ReadLine().ToLower();

bool isAdmin = (role == "admin");
if (isAdmin)
    Console.WriteLine("Access granted. Welcome!");
else
    Console.WriteLine("Access denied!");



    