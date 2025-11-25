using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP_quiz_Kevin
{
    internal class Program
    {
        static List<string> questions = new List<string>();
        static List<string> awnser1 = new List<string>();
        static List<string> awnser2 = new List<string>();
        static List<string> awnser3 = new List<string>();
        static List<string> awnser4 = new List<string>();
        static List<int> correctAwnser = new List<int>();
        static List<int> playerAwnser = new List<int>();
        static int Score = 0;
        static void Main(string[] args)
        {
            //question 1

            //question 2

            //question 3

            //question 4

            //question 5

            //question 6

            //question 7

            //question 8

            //question 9

            //question 10



            int questionTotal = questions.Count;

            for (int i = 0; i < questionTotal; i++)
            {
                Console.Clear();
                Console.WriteLine(questions[i]);
                Console.WriteLine(awnser1[i]);
                Console.WriteLine(awnser2[i]);
                Console.WriteLine(awnser3[i]);
                Console.WriteLine(awnser4[i]);

            }

            for (int i = 0; i < questionTotal; i++)
            {
                if (playerAwnser[i] == correctAwnser[i])
                {
                    Score++;
                }

            }












        }
    }
}
