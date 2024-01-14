/* AUTHOR: Seth Brock
 * SECTION: 001
 * IS 413 - Hilton
 * Assignment Name: Mission #2
 * Short Description: a console-based mini-game to roll two dice a certain number of times based on user input
 *                    and keep track of the combinations rolled
 */
/* PROJECT DESCRIPTION:
    Write a .NET console application using C# that simulates the rolling of two 6-sided dice. Use an
    Array to keep track of the number of times that each combination is thrown. In other words,
    keep track of how many times the combination of the two simulated dice is 2, how many times
    the combination is 3, and so on, all the way up through 12.
    Allow the user to choose how many times the “dice” will be thrown. Then, once you have the
    number of rolls, pass that number to a second class that has a method that simulates the roll of
    the dice for the number of times that the user specified. That method in the second class should
    return the array containing the results. In the first class, use that array to print a histogram (using
    the * character) that shows the total percentage each number was rolled. Each * will represent
    1% of the total rolls.
    Sample session:
    Welcome to the dice throwing simulator!
    How many dice rolls would you like to simulate? 1000
    DICE ROLLING SIMULATION RESULTS
    Each "*" represents 1% of the total number of rolls.
    Total number of rolls = 1000.
    2: ***
    3: ***
    4: ***********
    5: ***********
    6: ********
    7: ******************
    8: ****************
    9: **********
    10: *************
    11: *****
    12: **
    Thank you for using the dice throwing simulator. Goodbye!
    NOTE: Due to rounding issues and the fact that you cannot print a partial asterisk, your total
    number of asterisks printed may not be exactly 100.
    Submit a link to your GitHub repository containing your project via Learning Suite.
 */

using Mission2Dice;

internal class DiceRoll
{
    // Main function to run program
    private static void Main(string[] args) {
        /****************VARIABLE INITIALIZATION****************/
        int diceRolls; // User-inputted integer for how many times to roll dice
        bool indivOrPcnt = false; // False makes it so we output astrisks according to percent

        /*********************GETTING INPUTS********************/
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        // If a number of dice rolls was not given initially upon program execution, have the user enter a number
        if (args.Length == 0) {
            System.Console.WriteLine("How many dice rolls would you like to simulate?"); // Ask the user
            
            // Implemented a try/catch block to set diceRolls to 10 automatically if not input is given
            try { diceRolls = int.Parse(System.Console.ReadLine()); } // Read the user input
            catch (System.FormatException) { diceRolls = 10; } // If the exception is thrown, assign diceRools to 10
        }
        // If a number of dice rolls was given initially upon program execution, just use that
        else { 
            diceRolls = int.Parse(args[0]); 
            try { indivOrPcnt = bool.Parse(args[1]); } // Second argument entered at initialization toggles indivOrPcnt
            catch (System.FormatException) { indivOrPcnt = false; } // If it fails keep at false by default
        }

        /***********************ROLL DICE***********************/
        DiceRolling dr = new DiceRolling(diceRolls); // Initialize
        dr.rollDice(); // Roll the dice

        /*****************OUTPUT WITH ASTRISKS******************/
        dr.printDiceRolls(indivOrPcnt); // Call method to print the dice. Setting to false will do percentages
    }
}