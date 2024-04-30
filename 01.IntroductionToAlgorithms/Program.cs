using _01.IntroductionToAlgorithms;

internal class Program
{
    private static void Main(string[] args)
    {
        var myList = new List<int> { 1, 3, 5, 7, 9 };
        Console.WriteLine(BinarySearch.BinarySearchMethod(myList, 3));
        Console.WriteLine(BinarySearch.BinarySearchMethod(myList, -1));
    }
}