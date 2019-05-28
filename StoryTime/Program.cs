using System;

namespace cs_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My World ");
            Console.WriteLine("Keep Moving");
            
            
            Console.WriteLine("How's it going?");
            
            Console.WriteLine("The Game of Rock,Papers,Scissors");
            string answer = Console.ReadLine();

            if (answer == "rock")
            {
                Console.WriteLine("The other person chose scissors. You Win!");
            }
            if (answer == "paper")
            {

                Console.WriteLine("You lose, you got cut by scissors!");
            }

            if (answer == "scissors")
            {

                Console.WriteLine("You win you are cut from a different cloth!");
            }

            else
            {
                Console.WriteLine("Thats it game over!!!");
            }
                             

        }

    }

}


            