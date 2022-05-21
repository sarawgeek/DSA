// See https://aka.ms/new-console-template for more information
int[] arr = {15};
arr = QuickSort(arr, 0, arr.Length-1);
foreach (int i in arr)
{
    Console.Write(i + " ,");
}

static int[] QuickSort(int[] arr, int start, int end)
{
    //Console.WriteLine("End element {0}",end);
    if (start >= end)
    {
        return arr;
    }
    int pivot = arr[end];
    int boundary = start-1;
    int i = start;
    

    while (i <= end)
    {
        if (arr[i] <= pivot)
        {
            arr = swap(arr, i, ++boundary);
            i++;
        }
        else
        {
            i++;
        }
    }
    
    QuickSort(arr,start,boundary-1);
    QuickSort(arr,boundary+1,end);
    return arr;
}

static int[] swap(int[] arr, int elem1, int elem2)
{
    var temp = arr[elem1];
    arr[elem1] = arr[elem2];
    arr[elem2] = temp;
    return arr;
    //Console.WriteLine($"elem1 now = {elem1} and elem 2 is {elem2}");
}
