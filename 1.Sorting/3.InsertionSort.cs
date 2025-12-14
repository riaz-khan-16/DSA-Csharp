public class InsertionSort
{
    
 public static List<int> Sort(List<int> arr)
    {

    for (int i=1 ; i<arr.Count; i++)
        {
            while (i>0 && arr[i] < arr[i - 1])
            {
                //swap
                int temp=arr[i];
                arr[i]=arr[i-1];
                arr[i-1]=temp;
                i--;

            }

        }


    Console.WriteLine(string.Join(", ",arr));
    return arr;
        
    }

}
