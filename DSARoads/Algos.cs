using System;
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
            for (int i = 0,j=0; i < input.Length; i++)
            {
                if(input[i] != 0)
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

            for (int i = 0,j=str.Length-1; i < str.Length; i++,j--)
            {
                if (str[i] != str[j])
                {
                    Console.WriteLine("Not a palindrom string");
                    return;
                }
            }

            Console.WriteLine("Palindrome String");
        }

        public void BubbleSort()
        {

        }

        public void BinarySearch()
        {
            int[] nums = new int[] { 12, 4, 5, 9, 10, 11, 12, 13 };




        }

        public void MinInAArray()
        {
            // Input: arr = [9,2,3,6]
            // Output: 2

            int[] numbers = new int[] {1, 9, 2, 3, 6 };


            int small = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if(small > numbers[i])
                {
                    small = numbers[i];
                }
            }

            Console.WriteLine("Smallest is " + small);
        }
    }
}
