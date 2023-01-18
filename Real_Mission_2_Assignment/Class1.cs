using System;
using System.Collections.Generic;
using System.Text;

namespace Mission_2_Assignment
{
    public class Go_Simulator
    {
        int counter = 0;
        public void RunGame(int userInput)
        {
            //Create the Array
            int[] myArray = new int[11];
            myArray[0] = 0; // 2
            myArray[1] = 0;
            myArray[2] = 0;
            myArray[3] = 0;
            myArray[4] = 0;
            myArray[5] = 0;
            myArray[6] = 0;
            myArray[7] = 0;
            myArray[8] = 0;
            myArray[9] = 0;
            myArray[10] = 0; // 12

            // Create Random Class
            Random r = new Random();

            // Begin the While Loop
            while (counter < userInput)
            {

                int numberOne = r.Next(1, 7);
                int numberTwo = r.Next(1, 7);


                int numberSum = numberOne + numberTwo;


                // If cases to increment the array properly
                if (numberSum == 2)
                {
                    myArray[0] = myArray[0] + 1;
                }
                if (numberSum == 3)
                {
                    myArray[1] = myArray[1] + 1;
                }
                if (numberSum == 4)
                {
                    myArray[2] = myArray[2] + 1;
                }
                if (numberSum == 5)
                {
                    myArray[3] = myArray[3] + 1;
                }
                if (numberSum == 6)
                {
                    myArray[4] = myArray[4] + 1;
                }
                if (numberSum == 7)
                {
                    myArray[5] = myArray[5] + 1;
                }
                if (numberSum == 8)
                {
                    myArray[6] = myArray[6] + 1;
                }
                if (numberSum == 9)
                {
                    myArray[7] = myArray[7] + 1;
                }
                if (numberSum == 10)
                {
                    myArray[8] = myArray[8] + 1;
                }
                if (numberSum == 11)
                {
                    myArray[9] = myArray[9] + 1;
                }
                if (numberSum == 12)
                {
                    myArray[10] = myArray[10] + 1;
                }
                counter++;
            }

            // THIS IS WORKING

            //This represents the total number of rolls
            int total = 0;


            // Go through the array to get the total
            for (int i = 0; i < myArray.Length; i++)
            {
                total += myArray[i];
            }

            // Begin the results output
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each * represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + userInput + "." + "\n");

            char star = '*';

            // These values calculate the percent of the total each roll has
            double percentTwo = (myArray[0] / (double)total) * 100;
            double percentThree = (myArray[1] / (double)total) * 100;
            double percentFour = (myArray[2] / (double)total) * 100;
            double percentFive = (myArray[3] / (double)total) * 100;
            double percentSix = (myArray[4] / (double)total) * 100;
            double percentSeven = (myArray[5] / (double)total) * 100;
            double percentEight = (myArray[6] / (double)total) * 100;
            double percentNine = (myArray[7] / (double)total) * 100;
            double percentTen = (myArray[8] / (double)total) * 100;
            double percentEleven = (myArray[9] / (double)total) * 100;
            double percentTwelve = (myArray[10] / (double)total) * 100;


            // These values create the right amount of stars for each roll possibility
            string valueTwo = new string(star, (int)percentTwo);
            string valueThree = new string(star, (int)percentThree);
            string valueFour = new string(star, (int)percentFour);
            string valueFive = new string(star, (int)percentFive);
            string valueSix = new string(star, (int)percentSix);
            string valueSeven = new string(star, (int)percentSeven);
            string valueEight = new string(star, (int)percentEight);
            string valueNine = new string(star, (int)percentNine);
            string valueTen = new string(star, (int)percentTen);
            string valueEleven = new string(star, (int)percentEleven);
            string valueTwelve = new string(star, (int)percentTwelve);


            // Printing the lines that show the roll possibilty with the stars
            Console.WriteLine("2: " + valueTwo);
            Console.WriteLine("3: " + valueThree);
            Console.WriteLine("4: " + valueFour);
            Console.WriteLine("5: " + valueFive);
            Console.WriteLine("6: " + valueSix);
            Console.WriteLine("7: " + valueSeven);
            Console.WriteLine("8: " + valueEight);
            Console.WriteLine("9: " + valueNine);
            Console.WriteLine("10: " + valueTen);
            Console.WriteLine("11: " + valueEleven);
            Console.WriteLine("12: " + valueTwelve + "\n");

        }

    }
}
