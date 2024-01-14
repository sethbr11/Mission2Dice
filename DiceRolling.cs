/* AUTHOR: Seth Brock
 * SECTION: 001
 * IS 413 - Hilton
 * Assignment Name: Mission #2
 * Short Description: a class file containing the class and all the methods needed to run a dice rolling simulation
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Dice {
    internal class DiceRolling {
        /**********************ATTRIBUTES***********************/
        int numRolls; // How many times we are rolling the dice
        int[] numberRolls = new int[11]; // How many times each number combo was rolled, set to 11 for two dice
        private Random rndm = new System.Random(); // Random number class built in to C#

        /*********************CONSTRUCTORS**********************/
        public DiceRolling() {
            numRolls = 0;
            // Dice nums:  2  3  4  5  6  7  8  9 10 11 12
            numberRolls = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
        }
        public DiceRolling(int numberOfRolls) {
            numRolls = numberOfRolls; // Assign our class numRolls to the passed number of rolls
            numberRolls = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
        }

        /************************METHODS************************/
        public int[] rollDice() { // Method to roll all of the dice
            for (int i = 0; i < numRolls; i++) {
                int diceRollNumber = rollOneDice(); // Generate a random number from the helper function
                numberRolls[diceRollNumber - 2]++; // Increment the corresponding array index
            }

            return numberRolls; // Return it because the rubric says to
        }

        public void printDiceRolls(bool indiv, int[] rollArray) { // Method to output dice rolls
            // Initialize outputString with starter text
            string outputString = "DICE ROLLING SIMULATION RESULTS\n";
            if (indiv) { outputString += "Each \"*\" represents 1 roll.\n"; } // If set to indiv, output this
            else { outputString += "Each \"*\" represents 1 % of the total number of rolls.\n"; } // Otherwise, percent
            outputString += "Total number of rolls = " + numRolls + "\n\n";

            // For loop to output each dice roll possibility and the relating asterisks
            for (int diceNum = 0; diceNum < rollArray.Length; diceNum++) {
                int numAsterisk = 0;
                outputString += (diceNum + 2) + ": "; // Start the line with the dice roll number

                // If it was checked for individual rolls, set numAsterisk equal to the number of each roll
                if (indiv) { numAsterisk = rollArray[diceNum]; }
                // If marked to percent, calculate the percentage of rolls and set numAsterisk accordingly
                else {
                    // Calculate the percent, convert rollArray[diceNum] to a float just in the line to do calculation
                    float asAPercent = ((float)rollArray[diceNum] / numRolls) * 100;
                    numAsterisk = (int)System.Math.Round(asAPercent); // Now round the percentage to the nearest int
                }

                // Output the asterisks
                for (int i = 0; i < numAsterisk; i++) { outputString += "*"; }

                outputString += "\n"; // New line
            }

            // Output end text
            outputString += "\nThank you for using the dice throwing simulator. Goodbye!";
            if (!indiv) { // If it was done as a percentage we'll add this note
                outputString += "\n\nNOTE: Due to rounding issues and the fact that you cannot print a partial " +
                    "asterisk, your total\nnumber of asterisks printed may not be exactly 100."; 
            }

            System.Console.WriteLine(outputString);
        }

        /********************HELPER METHODS*********************/
        private int rollOneDice() {
            // Generate the random numbers
            int dice1Num = rndm.Next(1, 7); // Generate the first random number (includes 1, excludes 7)
            int dice2Num = rndm.Next(1, 7); // Generate the second random number the same way

            return dice1Num + dice2Num;
        }
    }
}
