using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int count = 0;
        int correctAnswers = 0;
        int incorrectAnswers = 0;
        int number = 1;
        int num1, num2, sumNum;
        while (count < 10)
        {

            Console.WriteLine("Answer 10 questions:  (Enter -1 to exit)");
            Console.WriteLine("Question {0}", ++count);
            num1 = random.Next(1, 10);
            num2 = random.Next(1, 10);
            sumNum = num1 + num2;
            Console.WriteLine("{0} + {1} = ?", num1, num2);
            string x = Console.ReadLine();
            bool result = Int32.TryParse(x, out number);
            if (result)
            {
                if (number == -1)
                {
                    Environment.Exit(0);
                }
                if (number == sumNum)
                {
                    Console.WriteLine("Correct!");
                    correctAnswers++;
                }
                else
                {
                    Console.WriteLine("Sorry, the correct answer is {0}", sumNum);
                    incorrectAnswers++;
                }
                Console.WriteLine();
            }
        }
        Console.WriteLine("Game over!");
        Console.WriteLine("You had {0} correct answers", correctAnswers);
        Console.WriteLine("You had {0} incorrect answers", incorrectAnswers);
        Console.ReadLine();
    }
}