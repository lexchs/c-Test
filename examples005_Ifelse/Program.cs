Console.WriteLine("Tell me your name:");
string username = Console.ReadLine();

if(username.ToLower() == "dasha")
{
    Console.WriteLine("Hello, kit");
}

else
{
    Console.Write("Hello, ");
    Console.Write(username);
}