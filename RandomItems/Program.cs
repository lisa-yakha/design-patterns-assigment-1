namespace RandomItems;


class Program
{
    static void Main(string[] args)
    {
        Manager itemOfPlayerOne = new ItemGenerator();
        Item current = itemOfPlayerOne.ManageItems("hammer");
        Console.ReadKey();

    }
}