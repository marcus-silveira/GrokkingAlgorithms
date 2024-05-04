using _04.QuickSort;

internal class Program
{
    private static void Main(string[] args)
    {
        var arr = new[] { 10, 5, 2, 3, 7, 11,20, 13 };
        Console.WriteLine(string.Join(", ", QuickSort.QuickSortMethod(arr)));
    }
}