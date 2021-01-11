using System;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created a Menu Bar to Find and Explain Prime Numbers.
            Console.WriteLine("1 = Find Prime Numbers");
            Console.WriteLine("2 = About Prime Number");
            int choose = int.Parse(Console.ReadLine());
            Console.Clear();
            if (choose == 1)
            {
                Prime();
                return;
            }
            //About Prime Number.
            else if (choose == 2)
            {
                Console.WriteLine(" → Prime number is a number that is divisible only by itself and 1");
                Console.WriteLine(" → Do not forget that 2 is also Prime Number");
                Console.WriteLine("*****************************");
                Console.WriteLine("Find Prime Numbers press M");
                string input = Console.ReadLine().ToLower();

                Console.Clear();

                if (input == "m")
                {
                    Prime();
                     return;
                }
            }
        }

        private static void Prime()
        {
            Console.WriteLine("Enter the maximum number: ");
            int n = int.Parse(Console.ReadLine());
            
            SieveOfEratosthenes(n);
        }
        
        private static void SieveOfEratosthenes(int n)
        {
            Console.Clear();
            Console.WriteLine($"Prime Numbers From 2 to {n} are below; ");

            bool[] prime = new bool[n + 1];

            //List all number from 0 to given numbers.
            for (int i = 0; i <= n; i++)
                prime[i] = true;

            //Check non Prime Numbers.
            for (int p = 2; p * p <= n; p++)
            {
                
                if (prime[p] == true)
                {
                    
                    for (int i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }

            //Shows All Prime Number Between 2 and given value.
            for (int i = 2; i <= n; i++)
            {
                 if (prime[i] == true)
                 Console.WriteLine(i + ",");
            }

            //Get Back to Function to Find a New Prime Numbers.
            Console.WriteLine("Press 'Enter' to Find New Prime Numbers ");
                
            string value = Console.ReadLine().ToLower();
            Console.Clear();

            if (value == "" + "")
            {
                Prime();
                return;
            }
            
        }
    }
} 
            
        
    

