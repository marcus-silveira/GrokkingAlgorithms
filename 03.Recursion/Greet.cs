namespace _03.Recursion;

public class Greet
{
    private static void GreetMethod(string name)
    {
        Console.WriteLine($"hello, {name}!");
        Greet2(name);
        Console.WriteLine("getting ready to say bye...");
        Bye();
    }

    private static void Greet2(string name)
    {
        Console.WriteLine($"how are you, {name}?");
    }

    private static void Bye()
    {
        Console.WriteLine("ok bye!");
    }
}