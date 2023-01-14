Console.Write("ВВедите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "айзада")
{
    Console.WriteLine("Ура! Это же Айзада!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}