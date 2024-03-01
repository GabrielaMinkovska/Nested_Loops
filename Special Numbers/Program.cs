namespace Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine() ?? "1");

            // now, let's iterate through all numbers and print only the special ones
            for (int cn = 1111; cn <= 9999; cn++)
            {
                // let's verify if `cn` is "special"

                String cnDigits = cn.ToString();

                bool isSpecial = true; // we accept that `cn` is special, unless proven otherwise

                for (int curDigit = 0; curDigit < cnDigits.Length; curDigit++)
                {
                    int curDigitNumber = int.Parse(cnDigits[curDigit].ToString()); // make an `int` from the current digit

                    if (curDigitNumber == 0 || number % curDigitNumber != 0)
                    // ah, it contains zero, or there's a reminder from the integer division:
                    // it's not special: indicate that and break the inner cycle
                    {
                        isSpecial = false;
                        break; // break the curDigit cycle - no need to process more
                    }
                }

                if (isSpecial)
                    Console.Write(cn + " ");
            }
        }

        static void Main__()
        {
            int n = int.Parse(Console.ReadLine());

            for (int digit = 1111; digit <= 9999; digit++)
            {

                String digits = digit.ToString();

                bool isSpecial = true;
                for (int curDigitIdx = 0; curDigitIdx < digits.Length; curDigitIdx++)
                {
                    int curDigit = int.Parse(digits[curDigitIdx].ToString());

                    if (curDigit == 0)
                    {
                        isSpecial = false;
                        break;
                    }

                    if (n % curDigit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }

                if (isSpecial)
                    Console.Write(digit + " ");
            }

            Console.WriteLine();
        }
    }
}