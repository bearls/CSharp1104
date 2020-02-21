using System;

namespace Lab3_5_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string blackListWord = "Slut";
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("I know you are, but what am I? Time for Facebook Jail!");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("Try again");
            }
       
                    
                    
        }
    }
} 
