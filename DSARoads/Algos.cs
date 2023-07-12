using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSARoads
{
    internal class Algos
    {
        public void RemoveEvenNumber()
        {
            // Input: Arr = [1,2,4,5,10,6,3]
            // Output: Arr = [1,5,3]
            int[] input = new int[] { 1, 2, 4, 5, 10, 6, 3 };

            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    input[i] = 0;
                    counter++;
                }
            }

            int size = input.Length - counter;
            int[] temp = new int[size];
            for (int i = 0, j = 0; i < input.Length; i++)
            {
                if (input[i] != 0)
                {
                    temp[j] = input[i];
                    j++;
                }
            }


            input = temp;

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }


        }

        public void PalindromString()
        {
            string str = "Madam";

            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                if (str[i] != str[j])
                {
                    Console.WriteLine("Not a palindrom string");
                    return;
                }
            }

            Console.WriteLine("Palindrome String");
        }

        public int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;

        }

        public void BinarySearch()
        {
            int[] nums = new int[] { 12, 4, 5, 9, 10, 11, 12, 13 };


            nums = BubbleSort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + ", ");
            }

            int lower = 0;
            int upper = nums.Length - 1;
            int searchKey = 11;

            while (lower <= upper)
            {
                int mid = (lower + upper) / 2;

                if (nums[mid] == searchKey)
                {
                    Console.WriteLine("Found " + nums[mid] + " at " + mid);
                    return;
                }
                else if (searchKey > nums[mid])
                {
                    lower = mid + 1;
                }
                else
                {
                    upper = mid - 1;
                }
            }

        }

        public void MinInAArray()
        {
            // Input: arr = [9,2,3,6]
            // Output: 2

            int[] numbers = new int[] { 1, 9, 2, 3, 6 };


            int small = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (small > numbers[i])
                {
                    small = numbers[i];
                }
            }

            Console.WriteLine("Smallest is " + small);
        }

        /// <summary>
        /// This give maximum sum available in the array. Also known as Kadan's Algo
        /// </summary>
        public void FindMaxSum()
        {
            int[] arr = { -4, 2, -5, 1, 2, 3, 6, -5, 1 };

            int max_sum = 0;
            int global_max = 0;

            if (arr.Length == 0) return;

            for (int i = 0; i < arr.Length; i++)
            {
                if (max_sum < 0)
                {
                    max_sum = arr[i];
                }
                else
                {
                    max_sum += arr[i];
                }

                if (global_max < max_sum)
                {
                    global_max = max_sum;
                   
                }
            }


            Console.WriteLine("Max Sum: " + global_max);
        }
    }
}
