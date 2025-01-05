using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Text;
using System.Collections;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            /*
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.WriteLine("Array 1 = "+string.Join(",",arr1));
            Console.WriteLine("Array 2 = " + string.Join(",", arr2));
            */

            //2.
            /*
            String[] list = { };

            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                String input = Console.ReadLine();
                if (input == "--")
                {
                    list = new String[0];
                    Console.WriteLine("List cleared");
                }
                else if (input.StartsWith("+"))
                {
                    String[] newList = new String[list.Length + 1];
                    if (list.Length > 0)
                    {
                        list.CopyTo(newList, 0);
                    }

                    newList[list.Length] = input.Substring(1);
                    list = newList;
                    Console.WriteLine("Item added");
                }
                else if (input.StartsWith("-"))
                {
                    int positionArray = Array.IndexOf(list, input.Substring(1));
                    if (positionArray != -1)
                    {
                        String[] newList = new string[list.Length - 1];

                        for (int i = 0; i < list.Length; i++)
                        {
                            int pointer = 0;
                            if (i != positionArray)
                            {
                                newList[pointer] = list[i];
                                pointer++;
                            }

                        }
                        list = newList;
                        Console.WriteLine("Item removed");
                    }
                    else
                    {
                        Console.WriteLine("Item not found");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid command");
                }

                Console.WriteLine("List contains:");
                for (int x = 0; x < list.Length; x++)
                {
                    Console.WriteLine(list[x]);
                }
            }
            */

            //3.
            /*
            int[] prime = FindPrimesInRange(0, 100);
            for (int i = 0;i< prime.Length; i++)
            {
                Console.Write(prime[i]+" ");
            }

            
*/
            //4
            /*
            Console.Write("Enter array: ");
            string[] input = Console.ReadLine().Split(' ');

            int[] arr = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = Convert.ToInt32(input[i]);
            }

            Console.Write("Enter Number of Rotation: ");
            int rotation = Convert.ToInt32(Console.ReadLine());

            int[] sum = new int[input.Length];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = 0;
            }

            for (int i = 1; i <= rotation; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    sum[j] += arr[(j+i)%arr.Length];
                }
            }

            for (int i = 1; i < sum.Length; i++)
            {
                Console.Write(sum[i] + " ");
            }
            Console.Write(sum[0]);
            */

            //5
            /*
            Console.Write("Enter array: ");
            string[] input = Console.ReadLine().Split(' ');

            int[] arr = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = Convert.ToInt32(input[i]);
            }
            int? maxChar = null;
            int maxOccurance = 0;
            int currOccurance = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (i == 0)
                {
                    maxChar = arr[i];
                }
                else if (arr[i] != arr[i - 1])
                {

                    if (currOccurance > maxOccurance)
                    {
                        maxOccurance = currOccurance;
                        maxChar = arr[i - 1];
                    }

                    currOccurance = 0;
                }
                else if(i == arr.Length - 1)
                {
                    currOccurance = currOccurance + 1;
                    if (currOccurance > maxOccurance)
                    {
                        maxOccurance = currOccurance;
                        maxChar = arr[i];
                    }
                }
                currOccurance =currOccurance+1;
                
            }
            for (int i = 0; i < maxOccurance; i++)
            {
                Console.Write(maxChar + " ");
            }
            */

            //7
            /*
            Console.Write("Enter array: ");
            string[] input = Console.ReadLine().Split(' ');

            int[] arr = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = Convert.ToInt32(input[i]);
            }
            int [] arr2 = new int[arr.Length];
            Array.Copy(arr, arr2, arr.Length);
            Array.Sort(arr);
            int? currValue = null;
            int currOccurence = 0;
            int[] values = { };
            int[] counts = { };
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    currValue = arr[i];
                }
                else if (arr[i] != arr[i - 1])
                {
                    int[] newValues = new int[values.Length + 1];
                    int[] newCounts = new int[counts.Length + 1];

                    values.CopyTo(newValues, 0);

                    counts.CopyTo(newCounts, 0);

                    newValues[values.Length] = arr[i - 1];
                    newCounts[counts.Length] = currOccurence;
                    values = newValues;
                    counts = newCounts;
                    currOccurence = 0;
                }
                else if (arr.Length - 1 == i)
                {
                    currOccurence++;
                    int[] newValues = new int[values.Length + 1];
                    int[] newCounts = new int[counts.Length + 1];
                    values.CopyTo(newValues, 0);
                    counts.CopyTo(newCounts, 0);
                    newValues[values.Length] = arr[i];
                    newCounts[counts.Length] = currOccurence;
                    values = newValues;
                    counts = newCounts;
                }
                currOccurence++;
            }


            int[] maxValues = { };
            for (int i = 0; i < counts.Length; i++)
            {
                int max = counts.Max();
                if (counts[i] == max)
                {
                    int[] newMaxValues = new int[maxValues.Length + 1];
                    maxValues.CopyTo(newMaxValues, 0);
                    newMaxValues[maxValues.Length] = values[i];
                    maxValues = newMaxValues;
                }

            }

            if (maxValues.Length == 1)
            {
                Console.Write("The number " + maxValues[0] + " is the most frequent (" + counts.Max() + " times)");
            }
            else
            {
                Console.Write("The numbers ");
                for (int i = 0; i < maxValues.Length - 1; i++)
                {
                    Console.Write(maxValues[i] + ", ");
                }
                Console.Write("and " + maxValues[maxValues.Length - 1] + " are the most frequent (" + counts.Max() + " times) ");

                int smallest = 0;

                    for (int j = 0; j < maxValues.Length; j++)
                    {
                        if (j == 0)
                        {
                            smallest = Array.IndexOf(arr2, maxValues[j]);
                        }
                        else if (Array.IndexOf(arr2, maxValues[j]) < smallest)
                        {
                            smallest = Array.IndexOf(arr2, maxValues[j]);
                        }
                        
                    }

                Console.WriteLine("The leftmost of them is " + arr2[smallest]);
            }
            */

            //1.
            /*
            Console.Write("Enter array: ");
            char[] input = Console.ReadLine().ToCharArray();
            char[] input2 = new char[input.Length];
            Array.Copy(input, input2, input.Length);    
            Array.Reverse(input);

            Console.WriteLine(new string(input));

            for (int i = input2.Length - 1; i >= 0; i--)
            {
                Console.Write(input2[i]);
            }
            */

            //2
            /*
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            string[] words = { };
            string separators = ".,:;=()&[]\"'\\/!? ";
            Queue q = new Queue();
            StringBuilder stringBuilder = new StringBuilder();
            foreach ( char c in input)
            {
                if (separators.Contains(c))
                {
                    if (stringBuilder.Length > 0)
                    {
                        string[] newWords = new string[words.Length + 1];
                        words.CopyTo(newWords, 0);
                        newWords[words.Length] = stringBuilder.ToString();
                        words = newWords;
                        stringBuilder.Clear();
                        q.Enqueue('w');
                    }
                    q.Enqueue(c);
                }
                else
                {
                    stringBuilder.Append(c);
                }
            }

            Array.Reverse(words);
            int wordsIndex = 0;

            while(q.Count > 0)
            {
                if (q.Peek().Equals('w'))
                {
                    Console.Write(words[wordsIndex]);
                    wordsIndex++;
                }
                else
                {
                    Console.Write(q.Peek());
                }
                q.Dequeue();
            }
            */

            //3. 
            /*
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            string[] words = { };
            string[] palindrome = { };
            string separators = ".,:;=()&[]\"'\\/!? ";
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in input)
            {
                if (separators.Contains(c))
                {
                    if (stringBuilder.Length > 0 || Array.IndexOf(words,stringBuilder)!=-1)
                    {
                        string[] newWords = new string[words.Length + 1];
                        words.CopyTo(newWords, 0);
                        newWords[words.Length] = stringBuilder.ToString();
                        words = newWords;
                        stringBuilder.Clear();
                    }
                }
                else
                {
                    stringBuilder.Append(c);
                }
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1){
                    int middleIndex = words[i].Length / 2;
                    string part2;
                    if(words[i].Length % 2 == 0)
                    {
                        char[] temp = words[i].Substring(middleIndex).ToCharArray();
                        Array.Reverse(temp);
                        part2 = new string(temp);
                        if(String.Equals(words[i].Substring(0, middleIndex), part2))
                        {
                            string[] newPalindrome = new string[palindrome.Length + 1];
                            palindrome.CopyTo(newPalindrome, 0);
                            newPalindrome[palindrome.Length] = words[i];
                            palindrome = newPalindrome;
                        }
                    }
                    else
                    {
                        char[] temp = words[i].Substring(middleIndex+1).ToCharArray();
                        Array.Reverse(temp);
                        part2 = new string(temp);
                        if (String.Equals(words[i].Substring(0, middleIndex), part2))
                        {
                            string[] newPalindrome = new string[palindrome.Length + 1];
                            palindrome.CopyTo(newPalindrome, 0);
                            newPalindrome[palindrome.Length] = words[i];
                            palindrome= newPalindrome;
                        }
                    }
                }
                else
                {
                    string[] newPalindrome = new string[palindrome.Length + 1];
                    palindrome.CopyTo(newPalindrome, 0);
                    newPalindrome[palindrome.Length] = words[i];
                    palindrome = newPalindrome;
                }
                
            }
            Array.Sort(palindrome);
            for (int i = 0; i < palindrome.Length-1; i++)
            {
                Console.Write(palindrome[i] + ", ");
            }
            Console.Write(palindrome[palindrome.Length-1]);
            */

            //4.
            /*
            Console.Write("Enter URL: ");
            string input = Console.ReadLine();
            string protocol = "", server = "", resource = "";
            string[] url = input.Split("://");
            string[] domain;
            if (url.Length == 2)
            {
                protocol = url[0];
                domain = url[1].Split('/');
            }
            else
            {
                domain = url[0].Split('/');
            }
            if (domain.Length == 2)
            {
                server = domain[0];
                resource = domain[1];
            }
            else
            {
                server = domain[0];
            }

            Console.WriteLine("Protocol: " + protocol);
            Console.WriteLine("Server: " + server);
            Console.WriteLine("Resource: " + resource);
            */

        }
            //3
            /*
            static int[] FindPrimesInRange(int start, int end)
            {
                int[] primes = new int[0];
                for (int i = start; i <= end; i++)
                {
                    if (i == 0 || i == 1)
                    {
                    }

                    if (IsPrime(i))
                    {
                        int[] newPrimes = new int[primes.Length + 1];
                        primes.CopyTo(newPrimes, 0);
                        newPrimes[primes.Length] = i;
                        primes = newPrimes;
                    }
                }
                return primes;
            }
            */
            //3
            /*
        static bool IsPrime(int i)
        {
            if (i <= 1) return false;
            if (i == 2) return true;

            if (i % 2 == 0) return false;
            for (int x = 2; x < i; x++)
            {
                if (i % x == 0) return false;
            }
            return true;
        }
            */

     }
}
