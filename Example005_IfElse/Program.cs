Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine(); // Possible null assignment.

if(username.ToLower() == "марина")
{
    Console.WriteLine("Ура, это же МАРИНА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username); 
}