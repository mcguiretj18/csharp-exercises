using System;
using System.Text;

namespace csharp_exercises
{
    class Program
    {
        // Exercise 11
        static void LookOlder(int age)
        {
            System.Console.WriteLine("You look older than {0}", age);
        }

        // Exercise 12
        static void PrintFourTimes(int num)
        {
            System.Console.WriteLine("{0} {0} {0} {0}", num);
            System.Console.WriteLine("{0}{0}{0}{0}", num);
            System.Console.WriteLine("{0} {0} {0} {0}", num);
            System.Console.WriteLine("{0}{0}{0}{0}", num);
        }

        // Exercise 13
        static void DisplayRectangle(int num)
        {
            if (num < 10)
            {
                System.Console.WriteLine("{0} {0} {0}", num);
                System.Console.WriteLine("{0}   {0}", num);
                System.Console.WriteLine("{0}   {0}", num);
                System.Console.WriteLine("{0}   {0}", num);
                System.Console.WriteLine("{0} {0} {0}", num);

            }
            else
            {
                System.Console.WriteLine("{0} {0} {0}", num);
                System.Console.WriteLine("{0}    {0}", num);
                System.Console.WriteLine("{0}    {0}", num);
                System.Console.WriteLine("{0}    {0}", num);
                System.Console.WriteLine("{0} {0} {0}", num);
            }
        }

        // Exercise 14
        static double KelvinToFahrenheit(float degrees)
        {
            return 1.8 * (degrees - 273) + 32;
        }

        // Exercise 15
        static string RemoveChar(string word, int idxToRemove)
        {
            // https://www.geeksforgeeks.org/c-sharp-remove-method/
            return word.Remove(idxToRemove, 1);
        }

        // Exercise 16
        static string SwapLetters(string word)
        {
            return word.Length > 1 ? word.Substring(word.Length - 1) + word.Substring(1, word.Length - 2) + word.Substring(0, 1) : word;
        }

        // Exercise 17
        static string AddFirstChar(string word)
        {
            var c = word[0];
            return word.Length > 1 ? word.PadLeft(word.Length + 1, c).PadRight(word.Length + 2, c) : word;
        }

        // Exercise 18
        static bool OneNegativeOnePositive()
        {
            System.Console.WriteLine("One number");
            var value1 = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Second number");
            var value2 = Convert.ToInt32(System.Console.ReadLine());

            if (value1 < 0 && value2 > 0)
            {
                return true;
            }
            else if (value2 < 0 & value1 > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Exercise 19
        static int Add(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }

        // Exercise 20
        static int AbsoluteDifference(int a, int b)
        {
            return a > b ? 2 * Math.Abs(a - b) : Math.Abs(a - b);
        }

        // Exercise 21
        static bool IsTwenty(int a, int b)
        {
            return (a == 20 || b == 20) || (a + b == 20);
        }

        // Exercise 22
        static bool IsTwentyRange(int n)
        {
            return (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20);
        }

        // Exercise 23
        static string ToLowerCase(string s)
        {
            return s.ToLower();
        }

        // Exercise 24
        static string LongestWord(string s)
        {
            var max = 0;
            var maxWord = "";

            foreach (var word in s.Split())
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }

            return maxWord;
        }

        // Exercise 25
        static void PrintOddNumbers()
        {
            for (var i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                    System.Console.WriteLine(i);
            }
        }

        static bool IsPrime(int n)
        {
            var x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            if (n % 2 == 0) return false; // even number

            for (var i = 2; i <= x; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        static long First500Prime()
        {
            var n = 2;
            long sum = 0;
            var counter = 0;
            while (counter < 500)
            {
                if (IsPrime(n))
                {
                    sum += n;
                    counter++;
                }
                n++;
            }

            return sum;
        }

        static bool WithinRange(int a, int b)
        {
            return Math.Abs(a) <= 10 && Math.Abs(b) <= 10;
        }

        static string SliceSection(string s)
        {
            if (s.IndexOf("H") == 1 && s.IndexOf("P") == 2)
            {
                return s[0] + s.Substring(2, s.Length);
            }

            return s;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine(SliceSection("PHP Tutorial"));
        }
    }
}
