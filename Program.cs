// See https://aka.ms/new-console-template for more information
namespace Example
{ class Program
    {
        public static void Main(string[] args)
        {
            //Algorithms.fibonaccirec(10);
            //Algorithms.fibonacciiter(10);
            //Algorithms.Prime(8);
            //Algorithms.Armstrong(152);
            //Algorithms.intPalindrome(0);
            Algorithms.strPalindrome("");
            


        }
    }
    // Basic Iterative & Recursive Algorithms
    class Algorithms
    {   // String Palindrome Iterative Algorithnm
        public static void strPalindrome(string text)
        {
            int i = 0;
            int j = text.Length - 1 ;
            bool Ispalindrome = false;
            while(i<j)
            {
                if (text[i] == text[j])
                {
                    i++;
                    j--;
                    Ispalindrome = true;

                }
                else
                {
                    Ispalindrome = false;
                    break;
                }

            }
            if (text.Length == 1 || Ispalindrome)
            { Console.WriteLine("Palindrome"); }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

        }
        // Palindrome Number Iterative Algorithnm
        public static void intPalindrome(int number)
        {
            int r = 0;
            int rev = 0;
            int temp = number;
            while (number != 0)
            {
                r = number % 10;
                number = number / 10;
                rev = r+(rev*10);
            }
            if(temp==rev)
            { Console.WriteLine("Palindrome"); }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            
        }
        // Armstrong Number Iterative Algorithnm
        public static void Armstrong(int n)
        {
            int sum = 0;
            int r;
            int temp = n;
            while(n!=0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n= n/10;
            }
            if (sum == temp)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            { Console.WriteLine("Not An Armstrong Number"); }
        }
        // Fibonacci Series Recursive Algorithm
        public static int FibonacciRec(int n)
        {
            if (n == 0 || n == 1)
            { return n; }
            else
            {
                return FibonacciRec(n - 1) + FibonacciRec(n - 2);
            }
        }
        public static void FibonacciIter(int n)
        {
            int first = 0;
            int second = 1;
            Console.Write(first + " " + second);
            int third;
            for (int i = 0; i < n-1; i++)
            {
                third = first + second;
                Console.Write(" " + third);
                first = second;
                second = third; 

            }
        }
        // Prime Number Iterative Algorithnm
        public static void Prime(int n)
        {
            bool isPrime = false;
            if (n >= 1)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = true;
                    }
                }
                if (!isPrime)
                    Console.WriteLine("Prime");
                else
                    Console.WriteLine("Not Prime Number");
            }
            else
            {
                Console.WriteLine("Not Prime Number");
            }
               
        }
    }
}
