public class SelectionSorting
{
    
    public static List<int> Sort(List<int> arr)
    {
        for (int i=0; i<arr.Count-1; i++)
        {
            int min_i=i;
            for (int j=i+1; j<arr.Count; j++)
            {
                if (arr[j] < arr[min_i])
                {
                    min_i=j;
                }

            }
            int temp=arr[min_i];
            arr[min_i]=arr[i];
            arr[i]=temp;


        }

        Console.WriteLine(string.Join(", ", arr));

        return arr;
       
    }

}

