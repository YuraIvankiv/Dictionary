using ConsoleApp11;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Завдання 1:");
        EmployeeManager manager = new EmployeeManager();
        manager.AddEmployee("YuraIv", "123456yura");
        manager.AddEmployee("PetroShmit", "Petro123");
        manager.AddEmployee("DimaT", "123456Dim");
        manager.GetPassword("YuraIv");
        manager.UpdateEmployee("YuraIv", "New123456");
        manager.GetPassword("YuraIv");
        manager.RemoveEmployee("PetroShmit");
        manager.GetPassword("PetroShmit");
        Console.WriteLine(" ");
        Console.WriteLine("Завдання 2:");

        Dictionary dict = new Dictionary();
        List<string> translations = new List<string> { "chat", "minou" };
        dict.AddWord("cat", translations);
        dict.SearchTranslation("cat");
    }

}