using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Dice {
    internal class DiceRolling {
        int numRolls; // How many times we are rolling the dice
        int[] numberRolls; // How many times each number combo was rolled

        /*********************CONSTRUCTORS**********************/
        public DiceRolling() {
            numRolls = 0;
            // Dice nums:  2  3  4  5  6  7  8  9 10 11 12
            numberRolls = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
        }
        public DiceRolling(int numberOfRolls) {
            this.numRolls = numberOfRolls; // Assign our class numRolls to the passed number of rolls
            numberRolls = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
        }

        /************************METHODS************************/
        public void rollDice() {
            
        }

        public void printDiceRolls() {
            // Initialize outputString with starter text
            string outputString = "DICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1 % of the total " +
                "number of rolls.\nTotal number of rolls = " + numRolls + "\n";

            // Iterate through the array to output the number of times each dice was rolled
            for (int diceNum = 0; diceNum < numberRolls.Length; diceNum++) {
                outputString += (diceNum + 2) + ": "; // Start the line with the dice roll number

                // Output the asterisks
                for (int numAsterisk = 0; numAsterisk < numberRolls[diceNum]; numAsterisk++) { outputString += "*"; }

                outputString += "\n"; // New line
            }

            // Output end text
            outputString += "Thank you for using the dice throwing simulator. Goodbye!\nNOTE: Due to rounding issues " +
                "and the fact that you cannot print a partial asterisk, your total\r\nnumber of asterisks printed may " +
                "not be exactly " + numRolls + ".";

            System.Console.WriteLine(outputString);
        }
    }
}
