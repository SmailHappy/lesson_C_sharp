Console.WriteLine("Введите имя епользователя: ");
string user_name = Console.ReadLine();

if (user_name.ToLower() == "маша")
{
    Console.WriteLine("Ура, Это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(user_name);
}
