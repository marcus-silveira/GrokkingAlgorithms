using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();

        var arr = new List<int> { 5, 3, 6, 2, 10 };
        var arr2 = new int[] { 5, 3, 6, 2, 10 };
        var numbers = new int[] { 4, 5, 1, 3, 10, 9, 6, 8, 7, 2 };


        // Double Selection Sort
        stopwatch.Start();
        var array = DoubleSelectionSort(new LinkedList<int>(numbers)).ToArray();
        stopwatch.Stop();
        Console.WriteLine($"Tempo de execução: {stopwatch.ElapsedTicks} ms");

        //stopwatch.Start();
        //SelectionSort(arr);
        //stopwatch.Stop();
        //Console.WriteLine($"Tempo de execução: {stopwatch.ElapsedTicks} ms");

        //stopwatch.Start();
        //SelectionSort(arr2);
        //stopwatch.Stop();
        //Console.WriteLine($"Tempo de execução: {stopwatch.ElapsedTicks} ms");

    }

    private static int[] SelectionSort(List<int> arr)
    {
        var newArr = new int[arr.Count];

        for (int i = 0; i < newArr.Length; i++)
        {
            var smallest = FindSmallest(arr);
            newArr[i] = arr[smallest];
            arr.RemoveAt(smallest);
        }

        return newArr;
    }

    private static int FindSmallest(List<int> arr)
    {
        var smallest = arr[0];
        var smallestIndex = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] < smallest)
            {
                smallest = arr[i];
                smallestIndex = i;
            }
        }

        return smallestIndex;
    }

    public static int[] SelectionSort(int[] unorderedArray)
    {
        for (var i = 0; i < unorderedArray.Length; i++)
        {
            var smallestIndex = i;

            for (var remainingIndex = i + 1; remainingIndex < unorderedArray.Length; remainingIndex++)
            {
                if (unorderedArray[remainingIndex] < unorderedArray[smallestIndex])
                {
                    smallestIndex = remainingIndex;
                }
            }
            (unorderedArray[i], unorderedArray[smallestIndex]) = (unorderedArray[smallestIndex], unorderedArray[i]);
        }

        return unorderedArray;
    }

    private static IEnumerable<int> DoubleSelectionSort(LinkedList<int> list)
    {
        var minList = new LinkedList<int>();
        var maxList = new LinkedList<int>();

        while (list.Count != 0)
        {
            var min = list.Min();
            list.Remove(min);
            minList.AddLast(min);

            var max = list.Max();
            list.Remove(max);
            maxList.AddFirst(max);
        }

        return minList.Union(maxList);
    }
}