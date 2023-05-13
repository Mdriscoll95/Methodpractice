internal class Program
{
    public static void Main(string[] args)
    {
        MadLibs();
    }
    public static void MadLibs()
    {
        Console.WriteLine(" what is your name?");
        var name = Console.ReadLine();
        Console.WriteLine("favorite color");
        var color = Console.ReadLine();
        Console.WriteLine("favorite animal");
        var animal = Console.ReadLine();
        Console.WriteLine("favorite band");
        var band = Console.ReadLine();

        Console.WriteLine($"hello {name}, you like {color}{animal} as a {band}");


    }

}