namespace Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // here we will store our statistical data, which we need to calculate at the end
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            while (true) // we will control with "break" when we will end this cycle
            {
                String movieName = Console.ReadLine() ?? "Finish";
                if (movieName == "Finish")
                    break; // no more movies, the movies cycle ends

                int hallSize = int.Parse(Console.ReadLine() ?? "0");

                int soldTickets = 0; // the number of sold tickets will accumulate here

                for (; soldTickets < hallSize;)
                {
                    String soldTicketType = Console.ReadLine() ?? "End";
                    if (soldTicketType == "End")
                        break; // no more tickets are sold for this movie

                    soldTickets++;
                    switch (soldTicketType)
                    {
                        case "student": studentTickets++; break;
                        case "kid": kidTickets++; break;
                        case "standard": standardTickets++; break;
                    }
                }

                // we got the info for all tickets for this movie
                // `soldTickets` contains the number of total sold tickets
                // print this movie's percentage
                Console.WriteLine($"{movieName} - {100.0 * soldTickets / hallSize:f02}% full.");
            }

            // We're done with all movies. Print the statistical info now
            int totalTickets = studentTickets + standardTickets + kidTickets; // all sold tickets
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{100.0 * studentTickets / totalTickets:f02}% student tickets.");
            Console.WriteLine($"{100.0 * standardTickets / totalTickets:f02}% standard tickets.");
            Console.WriteLine($"{100.0 * kidTickets / totalTickets:f02}% kids tickets.");
        }

        static void Main__()
        {
            int numberOfMovies = 0;

            int totalStudentTickets = 0;
            int totalKidTickets = 0;
            int totalStadardTickets = 0;

            while (true)
            {
                String movieName = Console.ReadLine();

                if (movieName == "Finish")
                    break;

                int movieSize = int.Parse(Console.ReadLine());

                int movieSoldTickets = 0;
                while (movieSoldTickets < movieSize)
                {
                    String ticketType = Console.ReadLine();

                    if (ticketType == "End")
                        break;

                    movieSoldTickets++;
                    switch (ticketType)
                    {
                        case "kid": totalKidTickets++; break;
                        case "student": totalStudentTickets++; break;
                        case "standard": totalStadardTickets++; break;
                    }
                }

                Console.WriteLine($"{movieName} - {movieSoldTickets * 100.0 / movieSize:f2}% full.");
            }

            int totalTickets = totalKidTickets + totalStadardTickets + totalStudentTickets;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{totalStudentTickets * 100.0 / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{totalStadardTickets * 100.0 / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{totalKidTickets * 100.0 / totalTickets:f2}% kids tickets.");
        }
    }
}