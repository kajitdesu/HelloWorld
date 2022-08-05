Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "kajit")
{
    Console.WriteLine("Ура, это же kajit!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}