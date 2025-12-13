
using System.Reflection.Metadata.Ecma335;

public class BubbleSorting
{
    public static List<int> Sort(List<int> arr)
    {
        {for (int i=0; i<arr.Count; i++)
                {
                for (int j=0; j<arr.Count-i-1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp=arr[j];
                            arr[j]=arr[j+1];
                            arr[j+1]=temp;
                        }
                    }


                }
        
       }
       Console.WriteLine(String.Join(", ",arr));
       return arr;
        
    }
        
       

}




