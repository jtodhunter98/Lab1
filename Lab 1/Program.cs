using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string start;
            Console.WriteLine("This is the Minnesota Driver's License Exam. This exam contains 20");
            Console.WriteLine("questions and will give immediate feedback on whether you passed or not");
            Console.WriteLine("To start testing, enter '1'");
            Console.WriteLine("To close the program, enter '0'");
            start = Console.ReadLine();
            while (start == "1")
            {
                string answer;
                string[] answerKey = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };
                string[] userAnswer = new string[20];
                int correct = 0;
                int questionNum = 1;
                for (int x = 0; x <= 19; x++)
                {
                    Console.WriteLine("Question " + questionNum);
                    Console.WriteLine("Enter answer: ");
                    userAnswer[x] = Console.ReadLine();
                    answer = userAnswer[x].ToUpper();
                    if (answer == answerKey[x])
                    {
                        correct = correct + 1;
                    }//end of if (for loop)
                    questionNum = questionNum + 1;
                }//end of for loop

                if (correct >= 15)
                {
                    Console.WriteLine("You passed with a score of: " + correct + " out of 20");
                }//end of if
                else
                {
                    Console.WriteLine("Sorry, you did not pass.");
                    Console.WriteLine("Your score: " + correct + " out of 20");
                }//end of else
                Console.WriteLine("Enter '1' to start another test");
                Console.WriteLine("Enter '0' to end the program");
                start = Console.ReadLine();
            
            }//end of while loop
          
        }//end of main
            
    }
}
