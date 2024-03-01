namespace Sum_of_Prime_and_Non_Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumOfPrimes = 0;
            int sumOfNonPrimes = 0;

            while (true)
            {
                String input = Console.ReadLine(); // get the next input

                if (input == "stop")
                    break; // we're done

                int number = int.Parse(input); // the input is a number, make it `int`

                if (number < 0) // Negative numbers require special treatment!
                {
                    Console.WriteLine("Number is negative.");
                    continue; // let's continue with our cycle from its beginning
                }

                // Now let's determine if "number" is Prime (https://www.techtarget.com/whatis/definition/prime-number)
                // A prime number is a whole number greater than 1 whose only factors are 1 and itself.
                // We use the algorithm, which we have been already provided.
                int divisors = 0;
                for (int i = 1; i <= number; i++)
                    if (number % i == 0)
                        divisors++;

                if (divisors == 2)
                    // only two divisors, this is a prime number
                    // add to the sum of prime numbers
                    sumOfPrimes += number;
                else
                    // more than two divisors, this number is not a prime number
                    // add to the sum of the non-prime numbers
                    sumOfNonPrimes += number;
            }

            Console.WriteLine("Sum of all prime numbers is: " + sumOfPrimes);
            Console.WriteLine("Sum of all non prime numbers is: " + sumOfNonPrimes);
        }
    }
}