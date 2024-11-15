using static System.Console;
class HelloUser
{
    static void Main()
    {
        String name;
        WriteLine("Введите Ваше имя:");
        name = ReadLine();
        WriteLine("Приветсвую Вас, " + name + "!");
        WriteLine("/infl завершения сеанса нажмите ENTER.");
        ReadLine();
    }
}
