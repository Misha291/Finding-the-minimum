public static void Main()
{
	Console.WriteLine(Min(new[] { 3, 6, 2, 4 }));
	Console.WriteLine(Min(new[] { "B", "A", "C", "D" }));
	Console.WriteLine(Min(new[] { '4', '2', '7' }));
}


public static object Min(Array arr)
{
    object min = arr.GetValue(0); 

    for (int i = 1; i < arr.Length; i++)
    {
        object currentItem = arr.GetValue(i); 
        IComparable current = (IComparable)currentItem;
        IComparable currentMin = (IComparable)min;

        if (current.CompareTo(currentMin) < 0)
        {
            min = currentItem; 
        }
    }

    return min; 
}
