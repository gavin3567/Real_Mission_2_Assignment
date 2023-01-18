using System;
using System.Collections.Generic;
using System.Text;

namespace Mission_2_Assignment
{
    public class Program
    {

        //Start
        public static void Main(string[] args)
        {
            Go_Simulator gs = new Go_Simulator(); // Declaration and Instantiation

            int userNumber = 0;

            Console.WriteLine("Welcome to the dice throwing simulator!" + "\n");

            Console.Write("How many dice rolls would you like to simulate? ");

            // Get user input on the number of times they want the dice to roll
            userNumber = int.Parse(Console.ReadLine());

            Console.Write("\n");

            // Call to run the dice game with the user input as the parameter
            gs.RunGame(userNumber);


            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");


            Console.ReadLine();
        }
    }
}
