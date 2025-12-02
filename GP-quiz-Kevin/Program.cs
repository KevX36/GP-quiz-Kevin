using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        static float Score = 0;
        static void Main(string[] args)
        {
            //question 1
            questions.Add("if an int with a value of 4 is divided by 10 than multipled by 100 in 1 line of code what will it return as\n(I might have found the awnser making this)");
            awnser1.Add("1: 40");
            awnser2.Add("2: 0");
            awnser3.Add("3: 400");
            awnser4.Add("4: 4");
            correctAwnser.Add(2);
            //question 2
            questions.Add("");
            awnser1.Add("1: ");
            awnser2.Add("2: ");
            awnser3.Add("3: ");
            awnser4.Add("4: ");
            correctAwnser.Add(1);
            //question 3
            questions.Add("");
            awnser1.Add("1: ");
            awnser2.Add("2: ");
            awnser3.Add("3: ");
            awnser4.Add("4: ");
            correctAwnser.Add(4);
            //question 4
            questions.Add("");
            awnser1.Add("1: ");
            awnser2.Add("2: ");
            awnser3.Add("3: ");
            awnser4.Add("4: ");
            correctAwnser.Add(4);
            //question 5
            questions.Add("in mario galaxy there is an thing that goes unused\nbut that every level calls on when loaded\nmaking the game crash if it's removed\n what was that item");
            awnser1.Add("1: super mushroom");
            awnser2.Add("2: F,L,U,D,D");
            awnser3.Add("3: waluigi");
            awnser4.Add("4: a yoshi egg");
            correctAwnser.Add(1);
            //question 6
            questions.Add("");
            awnser1.Add("1: ");
            awnser2.Add("2: ");
            awnser3.Add("3: ");
            awnser4.Add("4: ");
            correctAwnser.Add(1);
            //question 7
            questions.Add("");
            awnser1.Add("1: ");
            awnser2.Add("2: ");
            awnser3.Add("3: ");
            awnser4.Add("4: ");
            correctAwnser.Add(2);
            //question 8
            questions.Add("");
            awnser1.Add("1: ");
            awnser2.Add("2: ");
            awnser3.Add("3: ");
            awnser4.Add("4: ");
            correctAwnser.Add(1);
            //question 9
            questions.Add("");
            awnser1.Add("1: ");
            awnser2.Add("2: ");
            awnser3.Add("3: ");
            awnser4.Add("4: ");
            correctAwnser.Add(4);
            //question 10
            questions.Add("game math gave me a new nemesis, what is it:");
            //this awnser has an esteregg that needs it to be question 10
            awnser1.Add("1: home phone");
            awnser2.Add("2: ");
            awnser3.Add("3: rotations");
            awnser4.Add("4: changing individual vector3 values");
            correctAwnser.Add(3);


            int questionTotal = questions.Count;
            
            
            for (int i = 0; i < questionTotal; i++)
            {
                
                Console.WriteLine(questions[i]);
                Console.WriteLine(awnser1[i]);
                Console.WriteLine(awnser2[i]);
                Console.WriteLine(awnser3[i]);
                Console.WriteLine(awnser4[i]);

                awnser();
                Console.Clear();

            }

            for (int i = 0; i < questionTotal; i++)
            {
                if (playerAwnser[i] == correctAwnser[i])
                {
                    Score++;
                    Console.WriteLine($"you got question {i+1} correct");
                }
                else
                {
                    Console.WriteLine($"you got question {i+1} wrong");
                }
                if (i == 9 && playerAwnser[i] == 1)
                {
                    Console.WriteLine("no the house phone was my old nemesis");
                }
                
            }
            
            float finalScore = Score / questionTotal*100;
            Console.WriteLine($"your fianl score is {finalScore}%");
            if(finalScore == 0)
            {
                Console.WriteLine("wait a minite... you didn't get a single question right, HOW!\n Please tell me you did that intenionally");
            }
            if (finalScore == 100)
            {
                Console.WriteLine("you got a perfect score, good job\nunless you just brute forced it");
            }







            Console.ReadKey();
        }
        static void awnser()
        {
            Console.WriteLine("type the number of your awnser and hit enter to conferm");
            bool valadAwnser = false;
            while(valadAwnser == false)
            {
                
                string awnserInput = Console.ReadLine();
                if(awnserInput == "1")
                {
                    playerAwnser.Add(1);
                    valadAwnser = true;
                }
                else if (awnserInput == "2")
                {
                    playerAwnser.Add(2);
                    valadAwnser = true;
                }
                else if (awnserInput == "3")
                {
                    playerAwnser.Add(3);
                    valadAwnser = true;
                }
                else if (awnserInput == "4")
                {
                    playerAwnser.Add(4);
                    valadAwnser = true;
                }
                else
                {
                    Console.WriteLine("that is not a valad awnser\ndouble check you didn't hit something you didn't mean to");
                }
            }
        }
    }
}
