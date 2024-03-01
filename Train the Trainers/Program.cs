namespace Train_the_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryMembers = int.Parse(Console.ReadLine() ?? "0");

            double studentGradesSum = 0;
            int numberOfPresentations = 0;

            for (; ; numberOfPresentations++)
            {
                String presName = Console.ReadLine() ?? "Finish";

                if (presName == "Finish")
                    break; // done with all presentations

                double presentationGrades = 0;

                // read the evaluation of each jury member
                for (int curJury = 0; curJury < juryMembers; curJury++)
                    presentationGrades += double.Parse(Console.ReadLine() ?? "0");

                // print out the current presentation score
                Console.WriteLine($"{presName} - {presentationGrades / juryMembers:f2}.");

                // accumulate the current presentation score to the global score
                studentGradesSum += presentationGrades;
            }

            // print out the student's final results
            // note how we calculate the final results directly during printout, to avoid additional variable
            Console.WriteLine($"Student's final assessment is {studentGradesSum / numberOfPresentations / juryMembers:f2}.");
        }

        static void Main__()
        {
            int juriMembers = int.Parse(Console.ReadLine());

            double totalGradesSum = 0;
            int presentationCount = 0;
            while (true)
            {
                String presName = Console.ReadLine();

                if (presName == "Finish")
                    break;

                presentationCount++;

                double presentationAverage = 0;

                for (int juryMember = 1; juryMember <= juriMembers; juryMember++)
                {
                    double curGrade = double.Parse(Console.ReadLine());

                    presentationAverage += curGrade;
                    totalGradesSum += curGrade;
                }

                Console.WriteLine($"{presName} - {presentationAverage / juriMembers:f2}.");
            }

            Console.WriteLine($"Student's final assessment is {totalGradesSum / (presentationCount * juriMembers):f2}.");
        }
    }
}