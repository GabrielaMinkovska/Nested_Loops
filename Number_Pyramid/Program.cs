namespace Number_Pyramid;
class Program
{
    static void Main_compact()
    {
        int n = int.Parse(Console.ReadLine() ?? "0"); // the number from the input

        int row = 1; // the row we're curently printing
        for (int cur = 1; cur <= n;) // let's process all numbers
        {
            for (int print = 0; print < row && cur <= n; print++) // we print the current row either if the row finishes, OR if the row goes after `n`
                Console.Write($"{cur++} "); // print the current number, increase it AFTER the printing

            Console.WriteLine(); // finish the line
            row++;
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine() ?? "0"); // the number from the input

        int row = 1;
        int curRow = 0;
        for (int cur = 1; cur <= n; cur++)
        {
            Console.Write(cur + " ");

            curRow++;

            if (curRow >= row)
            {
                Console.WriteLine();
                row++;
                curRow = 0;
            }
        }
    }

    static void Main_lesson()
    {
        int n = int.Parse(Console.ReadLine() ?? "0"); // the number from the input

        int current = 1; // we start with `1`, and go until `n`, inclusive
        bool isBigger = false; // the indication for the end of the whole processing

        // let's start printing out rows
        for (int rows = 1; rows <= n; rows++)
        {
            // for each row, we print "rows" numbers
            // row 1 -> 1 number, "1 " 
            // row 2 -> 2 numbers, "2 3 "
            // row 3 -> 3 numbers, "4 5 6 ", ......
            for (int cols = 1; cols <= rows; cols++)
            {
                // check if we printed out all `n` numbers!
                if (current > n)
                {
                    // we're done!
                    isBigger = true;
                    break; // get out of the nested cycle for `cols`
                }
                Console.Write(current + " "); // print the number, add a space after it
                current++; // let's go to the next number
            }

            // the nested cycle indicated that we're done!
            if (isBigger)
                break; // get out of the main cycle, too

            Console.WriteLine(); // finish the new line from the previous cycle
        }
    }

    static void Main_()
    {
        int n = int.Parse(Console.ReadLine() ?? "0");

        int current = 1;
        bool isBigger = false;
        for (int rows = 1; rows <= n; rows++)
        {
            for (int cols = 1; cols <= rows; cols++)
            {
                if (current > n)
                {
                    isBigger = true;
                    break;
                }

                Console.Write(current + " ");
                current++;
            }

            Console.WriteLine();
            if (isBigger)
                break;
        }
    }
}

