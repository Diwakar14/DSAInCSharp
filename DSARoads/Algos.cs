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

        // Reverse a string
        public void ReverseAString()
        {
            string name = "Hello, my name is diwakar prasad";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                System.Console.Write(name[i]);
            }
        }

        // Reverse string by word
        public void ReverseStringByWord()
        {
            string message = "Hello, my name is diwakar prasad";

            // One way

            // var eachMessage = message.Split(" ");
            // for (int i = eachMessage.Length - 1; i >= 0; i--)
            // {
            //     if (i == 0)
            //     {
            //         System.Console.Write(eachMessage[i]);
            //     }
            //     else
            //     {
            //         System.Console.Write(eachMessage[i] + " ");
            //     }
            // }

            // Second Way without using the split function
            string ans = "";
            int prev = message.Length;
            int i;
            for (i = message.Length - 1; i >= 0; i--)
            {
                if (message[i] == ' ')
                {
                    int len = prev - i;
                    string sub = message.Substring(i + 1, len - 1);
                    ans += sub + ' ';
                    prev = i;
                }
            }

            ans += message.Substring(0, prev);
            System.Console.WriteLine(ans);
        }

        // Reverse a number and check palindrome
        public void ReverseANumber()
        {
            int num = 12145;
            int p = 0;
            while (num != 0)
            {
                int r = num % 10; // take out the last digit of the number
                p = p * 10 + r;
                num = num / 10; // remove the last digit of the number
            }

            System.Console.WriteLine(p);
        }

        public void PrintStar()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int k = i; k < 5; k++)
                {
                    System.Console.Write(" ");
                }
                for (int j = i; j >= 0; j--)
                {
                    System.Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void UniqueName()
        {
            string[] str1 = { "Diwakar", "Amit", "Kishor", "Ram" };
            string[] str2 = { "Prasad", "Kumar", "Kishor" };

            // One way
            // var data = str1.Union(str2).ToList();
            // foreach (var item in data)
            // {
            //     System.Console.WriteLine(item);
            // }

            // Another way by merging two lists.

            int i = 0, j = 0;
            string[] str = new string[str1.Length + str2.Length];

            int index = 0;

            while (i < str1.Length && j < str2.Length)
            {
                if (str1[i] != str2[j])
                {
                    str[index++] = str1[i++];
                    str[index++] = str2[j++];
                }
                else
                {
                    str[index++] = str1[i++];
                    j++;
                }
            }

            while (j < str2.Length)
            {
                str[index++] = str2[j++];
            }

            while (i < str1.Length)
            {
                str[index++] = str1[i++];
            }

            foreach (var item in str)
            {
                System.Console.WriteLine(item);
            }


        }

        public void CountCharacter()
        {
            Dictionary<char, int> mp = new Dictionary<char, int>();
            string name = "Hello, my name is diwakar Prasad";
            for (int i = 0; i < name.Length; i++)
            {
                if (mp.ContainsKey(name[i]))
                {
                    mp[name[i]]++;
                }
                else
                {
                    mp.Add(name[i], 1);
                }
            }

            foreach (var item in mp)
            {
                System.Console.WriteLine(item.Key + " " + item.Value);
            }

        }

        public bool CheckPalidrome(long num)
        {
            long p = 0;
            long temp = num;
            while (num != 0)
            {
                int r = (int)num % 10;
                p = p * 10 + r;
                num = num / 10;
            }

            if (temp == p) return true;
            return false;
        }

        public void PalindromicProductOfThree()
        {
            int num1 = 999;
            int num2 = 999;

            long largestPalindrome = 0;

            while (num1 > 99)
            {
                num2 = 999;
                while (num2 > 99)
                {
                    long prod = num2 * num1;
                    if (CheckPalidrome(prod))
                    {
                        if (largestPalindrome < prod)
                        {
                            largestPalindrome = prod;
                        }
                    }

                    num2--;
                }

                num1--;
            }



            System.Console.WriteLine(largestPalindrome);
        }

        public void SuffleDeckOfCard()
        {
            new Random(51);
        }

        public void FindLargestDigitInGivenN()
        {
            int number = 693123942;
            int largest = 0;

            while (number != 0)
            {
                int num = number % 10;
                if (num > largest)
                {
                    largest = num;
                }

                number = number / 10;
            }

            System.Console.WriteLine(largest);
        }

        public void MaxOccuranceOfChar()
        {
            string name = "Hello people, I am programming in c#";
            Dictionary<char, int> mp = new Dictionary<char, int>();
            int max = 0;
            char ch = ' ';

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] != ' ')
                {
                    if (mp.ContainsKey(name[i]))
                    {
                        mp[name[i]]++;
                    }
                    else
                    {
                        mp.Add(name[i], 1);
                    }
                }
            }

            foreach (var item in mp)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    ch = item.Key;
                }
            }

            foreach (var item in mp)
            {
                System.Console.WriteLine(item.Key + " " + item.Value);
            }

            System.Console.WriteLine(max + " " + ch);
        }

        public void FindDuplicateInArray()
        {
            int[] num = { 5, 3, 4, 9, 3, 6, 1, 5, 1 };
            Dictionary<int, int> mp = new Dictionary<int, int>();

            for (int i = 0; i < num.Length; i++)
            {
                if (mp.ContainsKey(num[i]))
                {
                    mp[num[i]]++;
                }
                else
                {
                    mp.Add(num[i], 1);
                }
            }

            foreach (var item in mp)
            {
                if (item.Value > 1)
                {
                    System.Console.WriteLine(item.Key);
                }
            }
        }

        public void FindSubSetHavingSumK()
        {

        }

    }
}
