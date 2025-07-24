using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element : ",  i + 1); 
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("=== Selection Sort (Ascending) ===");
            for (int i = 0; i < n; i++)
            {
                int minindex = i;
                for (int j = 0; j < n; j++) { 
                     if (arr[j] > arr[minindex])
                        {
                            minindex = j;
                        }
                     int temp=arr[i];
                    arr[i]=arr[minindex];
                    arr[minindex]=temp; 
                }
            }
            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(",",arr));


            Console.WriteLine("=== Selection Sort (Descending) ===");
            for (int i = 0; i < n; i++)
            {
                int minindex = i;
                for (int j = 0; j < n; j++)
                {
                    if (arr[j] < arr[minindex])
                    {
                        minindex = j;
                    }
                    int temp = arr[i];
                    arr[i] = arr[minindex];
                    arr[minindex] = temp;
                }
            }
            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(",", arr));

        }
    }
}
