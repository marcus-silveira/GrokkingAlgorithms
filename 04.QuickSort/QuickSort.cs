namespace _04.QuickSort;

public class QuickSort
{
    public static IEnumerable<int> QuickSortMethod(IEnumerable<int> list)
    {
        if (list.Count() < 2) return list;
        var pivot = list.First();
        var less = list.Skip(1).Where(x => x <= pivot);
        var greater = list.Skip(1).Where(i => i > pivot);
        //greater.ToList().
        return QuickSortMethod(less).Union(new List<int> { pivot }).Union(QuickSortMethod(greater));

    }
}

