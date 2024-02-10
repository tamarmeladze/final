
//    public class Calculator
//    {
//        public static void Main(string[] args)
//        {
//            while (true)
//            {
//                Console.WriteLine("Enter first number");
//                double num1 = double.Parse(Console.ReadLine());
//                Console.WriteLine("Enter second number");
//                double num2 = double.Parse(Console.ReadLine());
//                Console.WriteLine("Enter +,-,* or /");
//                char operation = char.Parse(Console.ReadLine());

//                if (operation == '+')
//                    Console.WriteLine("{0}+{1}={2}", num1, num2, num1 + num2);
//                else if (operation == '-')

//                    Console.WriteLine("{0}-{1}={2}", num1, num2, num1 - num2);
//                else if (operation == '*')
//                    Console.WriteLine("{0}*{1}={2}", num1, num2, num1 * num2);
//                else if (operation == '/')
//                    if (num2 == 0)
//                        Console.WriteLine("can't divide by zero");
//                    else
//                        Console.WriteLine("{0}/{1}={2}", num1, num2, num1 / num2);
//                else
//                    Console.WriteLine("Unrecognized character");

//                Console.WriteLine("press 'q' to quit or any other key to continue");
//                if (Console.ReadLine() == "q")
//                    break;
//                Console.Clear();
//            }
//        }

//    }
//}
using System.Data;

namespace finalur
{
    public class Gamocnobana
    {
        public static void Main()
        {
            Console.WriteLine("You have to guess number, first choose the level of game");
            Console.WriteLine("press 'e' - easy game 1-25 numbers, 'm' - medium game with 1-50numbers;   'h' - hard game 1-100 numbers!");
            char choice = char.Parse(Console.ReadLine());
            if (choice!='e' && choice!='m' && choice!='h')
            {
                Console.WriteLine("press correct character 'e','m' or 'h'");
                
            }
            int minnumber = 1;
            int maxnumber = 100;
            if (choice == 'e')
            { maxnumber = 25;
                            }
            else if (choice == 'm')
            { maxnumber = 50;
                            }
             Console.WriteLine("start guessing the number"); 
            Random random = new Random();
            int numbertoguess = random.Next(minnumber, maxnumber);
            int tries = 10;

            while (tries >0)
            {
                if (int.TryParse(Console.ReadLine(), out int guess))
                {
                    if (guess == numbertoguess)
                    {
                        Console.WriteLine("You Guessed the number !Game Over!");
                        break;
                    }
                    else if (guess < numbertoguess)
                    {
                        Console.WriteLine("try higher number");
                        
                                            }
                    else
                    { Console.WriteLine("try lower number");
                    }
                    tries--;
                } 
                             
             }
            if (tries == 0)
            { Console.WriteLine($"sorry,you lose, the number was {numbertoguess}"); }
        }
    }
}
    