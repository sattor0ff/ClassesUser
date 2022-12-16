User user1 = new User();
string l, p;
l = Console.ReadLine();
p = Console.ReadLine();
user1.Login(l, p);

System.Console.WriteLine("----------------");

System.Console.WriteLine($"{user1.GetFullInfo()}");  
