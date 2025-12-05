using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
            //this awnser has an esteregg so needs it to be question 1
            awnser1.Add("1: 40");
            awnser2.Add("2: 0");
            awnser3.Add("3: 400");
            awnser4.Add("4: 4");
            correctAwnser.Add(2);
            //question 2
            questions.Add("what's the shorthand to add a number to an int?");
            awnser1.Add("1: +=");
            awnser2.Add("2: ++");
            awnser3.Add("3: =+");
            awnser4.Add("4: there isn't one");
            correctAwnser.Add(1);
            //question 3
            questions.Add("why is the following line wrong \nif(string error = true){Console.wightline('this is wrong')}");
            awnser1.Add("1: declaring string in the if statment");
            awnser2.Add("2: using a string as a bool");
            awnser3.Add("3: the wight line is enterd wrong");
            awnser4.Add("4: all of the above");
            correctAwnser.Add(4);
            //question 4
            questions.Add("which of the following is not a use for Time.deltatime");
            awnser1.Add("1: timers");
            awnser2.Add("2: movement");
            awnser3.Add("3: gravity");
            awnser4.Add("4: triggers");
            correctAwnser.Add(4);
            //question 5
            questions.Add("in mario galaxy there is something that goes unused\nbut that every level calls on when loaded\nmaking the game crash if it's removed\n what was that thing");
            awnser1.Add("1: super mushroom");
            awnser2.Add("2: F,L,U,D,D");
            awnser3.Add("3: waluigi");
            awnser4.Add("4: a yoshi egg");
            correctAwnser.Add(1);
            //question 6
            questions.Add("what does ++ do");
            awnser1.Add("1: add 1");
            awnser2.Add("2: add whatever number is placed after");
            awnser3.Add("3: make a negitve number positive");
            awnser4.Add("4: add 10");
            correctAwnser.Add(1);
            //question 7
            questions.Add("what's wrong with the fallowing line of code\n vector3.position.y = 5");
            awnser1.Add("1: should have used +=");
            awnser2.Add("2: you can't directly edit a single vector 3 value");
            awnser3.Add("3: trying to enter an int as a vector 3");
            awnser4.Add("4: it needs to be a float value to work");
            correctAwnser.Add(2);
            //question 8
            questions.Add("which of the fallowing is not a console color");
            awnser1.Add("1: red");
            awnser2.Add("2: blue");
            awnser3.Add("3: pruple");
            awnser4.Add("4: black");
            correctAwnser.Add(3);
            //question 9
            questions.Add("which of the following will make this list made ouside a method work\nList<int> numbers =");
            awnser1.Add("1: add \"static\" before that line");
            awnser2.Add("2: add this after the =: new list<int>();");
            awnser3.Add("3: neither");
            awnser4.Add("4: both");
            correctAwnser.Add(4);
            //question 10
            questions.Add("game math gave me a new nemesis, what is it:");
            //this awnser has an esteregg so needs it to be question 10
            awnser1.Add("1: home phone");
            awnser2.Add("2: Making this");
            awnser3.Add("3: rotations");
            awnser4.Add("4: changing individual vector3 values");
            correctAwnser.Add(3);
            

            int questionTotal = questions.Count;
            bool playing = true;

            while (playing)
            {
                Console.Clear();
                Console.WriteLine("enter your name");
                string name = Console.ReadLine();
                //runs quiz
                for (int i = 0; i < questionTotal; i++)
                {
                    Console.WriteLine($"{name}\tcurrent question: {i+1}/{questionTotal}\tcurrent score: {Score / questionTotal * 100}%");
                    Console.WriteLine(questions[i]);
                    Console.WriteLine(awnser1[i]);
                    Console.WriteLine(awnser2[i]);
                    Console.WriteLine(awnser3[i]);
                    Console.WriteLine(awnser4[i]);

                    awnser();
                    
                    if (playerAwnser[i] == correctAwnser[i])
                    {
                        Score++;
                        Console.WriteLine("correct");
                    }
                    else
                    {
                        Console.WriteLine("wrong");
                    }
                    if (i == 0 && playerAwnser[i] == 1)
                    {
                        Console.WriteLine("that's what I thought too when I made this");
                    }
                    if (i == 9 && playerAwnser[i] == 1)
                    {
                        Console.WriteLine("no the house phone was my old nemesis");
                    }
                    Console.WriteLine("hit enter to Continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                // cheaks the score

                float finalScore = Score / questionTotal * 100;

                Console.WriteLine($"your fianl score is {finalScore}%");
                if (finalScore == 0)
                {
                    Console.WriteLine("wait a minite... you didn't get a single question right, HOW!\n Please tell me you did that intenionally");
                }
                if (finalScore == 100)
                {
                    Console.WriteLine("you got a perfect score, good job\nunless you just brute forced it but you wouldn't do that... right");
                }
                //cheak if the player wants to try again
                Console.WriteLine("do you want to play again, Y/N");
                bool Continue=true;
                while (Continue)
                {
                    string con = Console.ReadLine();
                    if (con == "Y")
                    {
                        
                        Continue = false;
                    }
                    else if (con == "y")
                    {

                        Continue = false;
                    }
                    else if (con == "N")
                    {
                        playing = false;
                        Continue = false;
                    }
                    else if (con == "n")
                    {
                        playing = false;
                        Continue = false;
                    }
                    else
                    {
                        Console.WriteLine("that's not a valad awnser");
                    }
                }
                



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
