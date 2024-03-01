namespace Equal_Sums_of_Even_and_Odd_Positions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine() ?? "0"); // we start from here
            int secondNum = int.Parse(Console.ReadLine() ?? "0"); // we finish here

            for (int i = firstNum; i <= secondNum; i++) // the main cycle, where we will process all numbers
            {
                String currentNum = i.ToString(); // let's make the current number to String

                int oddSum = 0; // we will accummulate the sum of all odd digits here
                int evenSum = 0; // we will accummulate the sum of all even numbers here
                for (int j = 0; j < currentNum.Length; j++) // we will process each character from the string
                {
                    Char c = currentNum[j];
                    int currentDigit = int.Parse(c.ToString()); // get the current digit from the number, but as `int`

                    if (j % 2 == 0) // add to the corresponding sum, depending on if the digit is even or not
                        oddSum += currentDigit;
                    else
                        evenSum += currentDigit;
                }

                if (oddSum == evenSum) // if both sums are equal, let's print the current number
                    Console.Write(i + " ");
            }
        }
    }
}