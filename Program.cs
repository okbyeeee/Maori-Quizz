namespace Maori_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t\t\t\t\t\tWelcome to the Te Reo Quiz!");//The name of the Quiz and the beautiful first welcome message
            Console.WriteLine("\n\nPlease enter your name: "); //asks user to Input their name (manners are key)
            string name1 = Console.ReadLine();
            Console.WriteLine("\n\n\n\n\n\n\n\t\t\tHello " + name1 + " ,There are Three Different Difficulties you can choose from \n\n\t\t\t(1)Easy\t\t(2)Intermediate\t\t(3)Impossible\t\t(4)Exit"); //welcomes user and asks them to choose their level depending on how smart they are. 

            int Thelevel;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out Thelevel))
                {
                    if (Thelevel == 1)
                    {
                        EasyMode();
                        break;
                    }
                    else if (Thelevel == 2)
                    {
                        IntermediateMode();
                        break;
                    }
                    else if (Thelevel == 3)
                    {
                        ImpossibleMode();
                        break;
                    }
                    else if (Thelevel == 4)
                    {
                        Console.WriteLine("Do you want to exit? (y/n)");
                        string exitInput = Console.ReadLine();
                        if (exitInput.ToLower() == "y")
                        {
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Whatever your doing isnt right. Please enter  1, 2, 3, or 4.\n\n\nTry Again!");//if the user fails to input 1-4 it tells them nicely that its wrong and they need to try again
                    }
                }
                else
                {
                    Console.WriteLine("Seriously " + name1 + ". Please just Enter 1, 2, 3, or 4.\n\n\nNot that hard\n Try again :)");
                    //if they still dont understand the code comes to life a bit and asks them to stop joking around and input a number between 1 and 4
                }
            }
        }//end of main method

        static void IntermediateMode()

        {
            Console.WriteLine(".");
            Console.Clear();
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\tLoading The Intermediate Quiz: ");
            string[] spinner = new string[] { "/", "-", "\\", "|" };
            for (int i = 0; i <= 50; i++)
            {
                Console.Write(spinner[i % spinner.Length]);
                System.Threading.Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
            Console.WriteLine("sending you to Indermediate mode");
            Console.Clear();

            string[] questions = new string[]
                {
                "What is the Maori word for 'Sun'?\nA) Rangi\nB) Marama\nC) Ra",//first question
                "What is the Maori word for 'family'?\nA) Whanau\nB) Kaumatua\nC) Kaitiaki",//second quesion
                " What is the Maori word for \"wind\"? \nA) Hau\nB) Ahi\nC) Kaha",//third quesion
                "What is the Maori word for 'Ccean'? \nA) Moana\nB) Awa\nC) Wai",//fourth question
                "5. What is the Maori word for \"earth\"? \nA) Whenua\nB) Awa\nC) Wai "//last quesion
                };

            int score = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                string answer = Console.ReadLine().ToUpper();

                if (answer == "A" || answer == "B" || answer == "C")
                {
                    if (answer == "A")
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong answer!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid answer!");
                }
            }

            Console.WriteLine("Your Final score is: " + score);

        }//end of intermediate mode

        static void ImpossibleMode()
        {
            int score = 0;
            Console.WriteLine(".");
            Console.Clear();
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\t\n\t\t\t\t\t\tLoading Impossible Quiz: ");
            string[] spinner = new string[] { "/", "-", "\\", "|" };
            for (int i = 0; i <= 50; i++)
            {
                Console.Write(spinner[i % spinner.Length]);
                System.Threading.Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
            Console.WriteLine("sending you: ");
            Console.Clear();
            Console.WriteLine("\n\n\t\t\t\t\t\tWelcome to Impossible Mode\n\n\t\t\t\tThere are Five Questions in this mode! Goodluck");
            Console.WriteLine("Quesion (1)\n How Do you say Hello in Maori\n(a)Sup G\n(b)Kia Ora\n(c)Hiii");


            Console.Read();
        }//end of Impossible quiz

        static void EasyMode()
        {

            //loading bar that looks cool and counts as an array? 2 in 1
            Console.Write("Loading The Easy Quiz: ");
            string[] spinner = new string[] { "/", "-", "\\", "|" };
            for (int i = 0; i <= 50; i++)
            {
                Console.Write(spinner[i % spinner.Length]);
                System.Threading.Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
            Console.WriteLine("sending you to easy mode");
            Console.Clear();
            Console.WriteLine("\n\t\t\t\t\tWelcome to Easy Mode!!\nThere are Five Questions, GoodLuck");
            {
                Console.WriteLine(".");
                Console.Clear();
                //loading bar that looks cool and counts as an array? 2 in 1
                Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\t\n\t\t\t\t\t\tLoading The Easy Quiz: ");
                string[] strings = new string[] { "/", "-", "\\", "|" };
                string[] spinner = strings;
                for (int i = 0; i <= 50; i++)
                {
                    Console.Write(spinner[i % spinner.Length]);
                    System.Threading.Thread.Sleep(100);
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                }
                Console.WriteLine("sending you to easy mode");
                Console.Clear();
                Console.WriteLine("\n\t\t\t\t\tWelcome to Easy Mode!!\nThere are Five Questions, GoodLuck");
                {
                    string[] questions = { "\n\n1)\nWhat is Red in Maori?\n(A)whero\n(B)Kakariki\n(C)parauri", "\n\n2)\nHow do you Greet somone?\n(A)Sup G\n(B)Kia Ora\n(C)morena", "\n\n3)\nWhat is the Maori Name for New Zealand?\n(A)White cloud\n(B)Aotearoa\n(C)New Zealand", "\n\n4)\nWhat is the Capital City of NZ?\n(A)Auckland\n(B)Queenstown\n(C)Wellington", "How Many People live in New Zealand?\n(A)200k\n(B)30 million\n(C)5 million" };
                    string[] answers = { "a", "b", "b", "c", "c" };
                    int score = 0;

                    for (int i = 0; i < questions.Length; i++)
                    {
                        Console.WriteLine(questions[i]);
                        string userAnswer = Console.ReadLine();

                        if (userAnswer.ToLower() == "a" || userAnswer.ToLower() == "b" || userAnswer.ToLower() == "c")
                        {
                            if (userAnswer.ToLower() == answers[i])
                            {
                                Console.WriteLine("Correct!");
                                score++;
                            }
                            else
                            {
                                Console.WriteLine("Incorrect.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid answer.");
                        }
                    }

                    Console.WriteLine("Well Done you completed the Quiz and your score is: " + score);
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\tTHANKS FOR PLAYING!!!!");
                    Console.Read();

                }
            }

        }
        //end of easy quiz

    }
}