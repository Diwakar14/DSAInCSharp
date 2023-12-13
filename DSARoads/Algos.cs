using System;
using System.Buffers;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
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

        public int[] SelectionSort(int[] arr)
        {
            return arr;
        }

        /// <summary>
        /// Thing of card suffing. Time Complexity O(n*n);
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>Sorted Array</returns>
        public int[] InsertionSort(int[] arr)
        {
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

        public int[] Randomize(int[] arr)
        {
            var rand = new Random();

            for (int i = 0; i <= 51; i++)
            {
                int newIndex = rand.Next(51);
                int temp = arr[i];
                arr[i] = arr[newIndex];
                arr[newIndex] = temp;
            }

            return arr;
        }
        public void SuffleDeckOfCard()
        {
            int[] card = new int[52];

            for (int i = 0; i <= 51; i++)
            {
                card[i] = i;
            }

            int[] suffledArr = Randomize(card);
            for (int i = 0; i <= 51; i++)
            {
                System.Console.WriteLine(suffledArr[i]);
            }


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
            int[] nums = { 1, 2, 3 };
            int[] nums = { 1, 2, 3, 5 };
            int k = 5;

            Dictionary<int, int> mp = new();
            mp[0] = 1;

            int sum = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (mp.ContainsKey(sum - k))
                {
                    count += mp[sum - k];
                }

                if (mp.ContainsKey(sum))
                {
                    mp[sum]++;
                }
                else
                {
                    mp.Add(sum, 1);
                }
            }

            System.Console.WriteLine(count);

            Dictionary<int, int> mp = new();

            mp[0] = 1;

            int sum = 0;
            int k = 3;

            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (mp.ContainsKey(sum - k))
                {
                    count += mp[sum - k];
                }

                if (mp.ContainsKey(sum))
                {
                    mp[sum]++;
                }
                else
                {
                    mp.Add(sum, 1);
                }
            }

            Console.WriteLine(count);


        }

        public void LongestSubstringWithNonRepeating()
        {

            string s = "abcaaaaaaaaaabcbb";
            int maxCount = 0;
            Dictionary<char, int> mp = new();

            for (int i = 0, j = 0; j < s.Length; j++)
            {
                if (mp.ContainsKey(s[j]))
                    mp[s[j]]++;
                else
                    mp.Add(s[j], 1);

                while (mp[s[j]] > 1)
                    mp[s[i++]]--;


                maxCount = Math.Max(maxCount, j - i + 1);

            }

            Console.WriteLine(maxCount);
        }

        public void LongestSubAtLeastKChar()
        {
            int k = 3, k2 = 2;
            //string s = "aaabb";
            string s = "dababebc";
            int count = 0;

            Dictionary<char, int> mp = new();
            int maxLen = 0;
            int i = 0, j = 0;

            while (j < s.Length && i < s.Length)
            {
                if (mp.ContainsKey(s[j])) mp[s[j]]++;
                else mp.Add(s[j], 1);

                if (mp[s[j]] == k2)
                    count++;

                if (count == mp.Count)
                    maxLen = Math.Max(maxLen, j - i + 1);

                j++;

                if (j == s.Length)
                {
                    mp.Clear();
                    count = 0;
                    i++;
                    j = i;
                }
            }

            Console.WriteLine(maxLen);

        }

        public void LargestSubEqualToZero()
        {
            int[] A = new int[] { 1, 2, -2, 4, -4 };

            Dictionary<int, int> mp = new();
            mp[0] = 1;
            int maxLen = 0;
            int sum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];

                if (sum == 0)
                {
                    maxLen = i + 1;
                }

                if (mp.ContainsKey(sum))
                {
                    maxLen = Math.Max(maxLen, i - mp[sum]);
                }
                else
                {
                    if (mp.ContainsKey(sum))
                    {
                        mp[sum] = i;
                    }
                    else
                    {
                        mp.Add(sum, i);
                    }
                }
            }

            Console.WriteLine(maxLen);


        }

        public void LongestSubArrLen()
        {
            int[] nums = new int[] { 0, 1, 1, 0, 0, 1 };

            Dictionary<int, int> mp = new();
            int sum = 0;

            int maxLen = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    sum += -1;
                }
                else
                {
                    sum += 1;
                }

                if (sum == 1)
                {
                    maxLen = i + 1;
                }
                else if (!mp.ContainsKey(sum))
                {
                    mp[sum] = i;
                }

                if (mp.ContainsKey(sum - 1))
                {
                    maxLen = Math.Max(maxLen, i - mp[sum - 1]);
                }
            }

            Console.WriteLine(maxLen);
        }

        public void FindRepeatingElement()
        {
            int[] nums = { 10, 5, 3, 4, 3, 5, 6 };

            Dictionary<int, int> mp = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (mp.ContainsKey(nums[i]))
                {
                    mp[nums[i]]++;
                }
                else
                {
                    mp.Add(nums[i], 1);
                }
            }


            foreach (var item in mp)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
        }

        public void TwoSum()
        {
            int k = 9;
            int[] nums = { 2, 7, 11, 15 };

            Dictionary<int, int> mp = new();


            for (int i = 0; i < nums.Length; i++)
            {
                if (mp.ContainsKey(k - nums[i]))
                {
                    Console.WriteLine(mp[k - nums[i]]);
                    Console.WriteLine(i);

                    break;
                }



                if (mp.ContainsKey(nums[i]))
                    mp[nums[i]] = i;
                else
                    mp.Add(nums[i], i);
            }


        }


        public void ThreeSum()
        {
            //int[] nums = { 12, 3, 4, 1, 6, 9 };
            int[] nums = { 1, 4, 45, 6, 10, 8 };
            int k = 22;
            Dictionary<int, int> mp = new Dictionary<int, int>();


            for (int i = 0; i < nums.Length - 2; i++)
            {

                int j = i + 1;
                while (j < nums.Length)
                {
                    int sum = nums[i] + nums[j];

                    if (mp.ContainsKey(k - sum))
                    {
                        Console.WriteLine(nums[mp[k - sum]]);
                        Console.WriteLine(nums[i]);
                        Console.WriteLine(nums[j]);

                        return;
                    }


                    if (mp.ContainsKey(nums[j]))
                    {
                        mp[nums[j]] = j;
                    }
                    else
                    {
                        mp.Add(nums[j], j);
                    }

                    j++;
                }


            }
        }


        public void FourSum()
        {
            int[] nums = { 10, 20, 30, 40, 1, 2 };
            int target = 91;

            Dictionary<int, int> mp = new();

            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = i + 1; j < nums.Length; j++)
                {

                    int k = j + 1;

                    while (k < nums.Length)
                    {
                        int sum = nums[i] + nums[j] + nums[k];
                        if (mp.ContainsKey(target - sum))
                        {

                            if (i != mp[target - sum] && j != mp[target - sum])
                            {
                                Console.WriteLine(nums[mp[target - sum]]);
                                Console.WriteLine(nums[k]);
                                Console.WriteLine(nums[j]);
                                Console.WriteLine(nums[i]);

                                return;
                            }

                        }

                        if (mp.ContainsKey(nums[k]))
                        {
                            mp[nums[k]] = k;
                        }
                        else
                        {
                            mp.Add(nums[k], k);
                        }

                        k++;
                    }

                }
            }


        }


        public void Diffk()
        {
            int[] nums = { 5, 20, 3, 2, 50, 80 };
            //int[] nums = { 1, 8, 30, 40, 100 };
            int k = 78;//-60;// 78;


            Dictionary<int, int> mp = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (mp.ContainsKey(nums[i] - Math.Abs(k)))
                {

                    if (i != mp[nums[i] - Math.Abs(k)])
                    {
                        Console.WriteLine(nums[mp[nums[i] - Math.Abs(k)]]);
                        Console.WriteLine(nums[i]);

                    }
                }

                if (mp.ContainsKey(nums[i]))
                {
                    mp[nums[i]] = i;
                }
                else
                {
                    mp.Add(nums[i], i);
                }
            }


        }

        public void Anangram()
        {
            string[] animals = { "cat", "dog", "god", "tca" };

            Dictionary<string, int> mp = new();


            for (int i = 0; i < animals.Length; i++)
            {
                var animal = string.Join("", animals[i].OrderBy(x => x).ToArray());
                if (mp.ContainsKey(animal.ToString()))
                {
                    Console.WriteLine(mp[animal.ToString()]);
                    Console.WriteLine(i);
                }

                if (mp.ContainsKey(animal.ToString()))
                {
                    mp[animal.ToString()] = i;
                }
                else
                {
                    mp.Add(animal.ToString(), i);
                }
            }

        }


        public void PairWithXor()
        {

            int k = 5;
            //int[] nums = { 5, 4, 10, 15, 7, 6 };
            int[] nums = { 3, 6, 8, 10, 15, 50 };

            Dictionary<int, int> mp = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (mp.ContainsKey(nums[i] ^ k))
                {
                    Console.WriteLine(nums[mp[nums[i] ^ k]]);
                    Console.WriteLine(nums[i]);
                }


                if (mp.ContainsKey(nums[i]))
                {
                    mp[nums[i]] = i;
                }
                else
                {
                    mp.Add(nums[i], i);
                }
            }

        }

        public void SubarrayWithXorK()
        {
            int[] nums = { 4, 2, 2, 6, 4 };
            //int[] nums = { 5, 6, 7, 8, 9 };
            //int k = 5;
            int k = 6;

            Dictionary<int, int> mp = new Dictionary<int, int>();
            mp[0] = 1;
            int xor = 0;
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                xor = xor ^ nums[i];
                int key = xor ^ k;

                if (mp.ContainsKey(key))
                {
                    if (mp[key] > 0)
                    {
                        count += mp[key];
                    }
                }

                if (mp.ContainsKey(nums[i]))
                {
                    mp[nums[i]]++;
                }
                else
                {
                    mp.Add(nums[i], 1);
                }
            }

            Console.WriteLine(count);

        }


        public void RotateArray()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;

            int[] arr = new int[nums.Length];

            k = k % nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                arr[(i + k) % nums.Length] = nums[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


        public void PivotIndex()
        {
            int[] nums = { 1, 7, 3, 6, 5, 6 };
            //int[] nums = { 2, 1, -1 };


            int[] prefixSum = new int[nums.Length + 1];
            int[] suffixSum = new int[nums.Length + 1];

            for (int i = 1, j = nums.Length - 1; i <= nums.Length && j >= 0; i++, j--)
            {
                prefixSum[i] = prefixSum[i - 1] + nums[i - 1];
                suffixSum[j] = suffixSum[j + 1] + nums[j];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (prefixSum[i + 1] == suffixSum[i])
                {
                    Console.WriteLine("Pivot is " + (i));
                }
            }

        }

        int AtMostSum(int[] arr, int goal)
        {
            int res = 0;
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                goal -= arr[i];

                while (goal < 0)
                {
                    goal += arr[j++];
                }
                res += i - j + 1;
            }
            return res;

        }

        public void BinarySubarraySumK()
        {
            int[] nums = { 1, 0, 1, 0, 1 };
            int k = 2;


            // Using sliding window
            int res = AtMostSum(nums, k) - AtMostSum(nums, k - 1);
            Console.WriteLine(res);


        }


        float atMostAvg(int[] arr, int goal)
        {
            int j = 0;
            int sum = 0;
            int temp = goal;
            float maxAvg = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                sum += arr[i];
                goal--;

                if (goal == 0)
                {
                    maxAvg = Math.Max(maxAvg, (float)((float)sum / (float)temp));
                    goal++;
                    sum = sum - arr[j++];
                }
            }

            return maxAvg;
        }

        public void MaxAverageSubarray()
        {
            int[] nums = { 1, 12, -5, -6, 50, 3 };
            int k = 4;


            // At most is not required as the goal should be exactly equal to the k
            float avg = atMostAvg(nums, k);

            Console.WriteLine(avg);

        }


        int atMostMinSum(int[] arr, int target)
        {
            int minLen = arr.Length + 1;

            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                target -= arr[i];

                while (target <= 0)
                {
                    target += arr[j];
                    minLen = Math.Min(minLen, i - j + 1);
                    j++;
                }
            }

            return minLen % (arr.Length + 1);
        }

        public void MinimumSizeSubarraySum()
        {
            int[] nums = { 2, 3, 1, 2, 4, 3 };
            int k = 7;

            Console.WriteLine(atMostMinSum(nums, k));
        }

        public void MaxConsecutiveOne()
        {
            int[] nums = { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };
            int k = 2;


            int j = 0;
            int maxLen = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) k--;

                while (k < 0)
                {
                    if (nums[j] == 0)
                    {
                        k++;
                    }

                    j++;
                }


                maxLen = Math.Max(maxLen, i - j + 1);

            }

            Console.WriteLine(maxLen);
        }

        public void MinimunPositiveMissing()
        {
            int[] nums = { 1, 2, 0 };

            int max = nums.Max();

            if (nums.Length == 1)
            {

                // If it contains only one element
                if (nums[0] == 1)
                {
                    Console.WriteLine(2);
                    return;
                }
                else
                {
                    Console.WriteLine(1);
                    return;
                }
            }

            int[] m = new int[max];

            int i;
            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    if(m[nums[i] - 1]!=1)
                    m[nums[i]-1] = 1;
                }
            }


            for (i = 0; i < m.Length; i++)
            {
                if (m[i] > 0) 
                {
                    Console.WriteLine(i+1);
                    return;
                }
            }

            Console.WriteLine(i+2);
        }

    }
}
