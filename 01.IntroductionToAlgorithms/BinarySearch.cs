namespace _01.IntroductionToAlgorithms;

public class BinarySearch
{
    public static int? BinarySearchMethod(IList<int> list, int item)
    {
        var low = 0;
        var high = list.Count - 1;

        while (low <= high)
        {
            var mid = (low + high) / 2;
            var guess = list[mid];

            if (guess == item) return mid;
            if (guess > item)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return null;
    }
}
