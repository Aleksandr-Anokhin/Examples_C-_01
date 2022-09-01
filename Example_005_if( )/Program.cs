Console.Write("Введите Ваше имя ");
string username = Console.ReadLine();

if(username.ToLower() == "alex")
{
    Console.WriteLine("Ура, это же Alex!");
}
else
{
    Console.Write("привет, ");
    Console.WriteLine(username);
}
