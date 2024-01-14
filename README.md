## Project Description
This program simulates rolling two dice and presenting to the user the results of the roles in a histogram, by default as a percentage.

## Features to Know
There is only one feature to know, and that is if you run the Program.exe file from the command line, there are two arguments you can input upon execution:<br><br>
<b><em>Program.exe number true/false</em></b><br><br>
The number you enter after <em>Program.exe</em> represents the number of rolls that you'll do of the two dice. You can do this in the program as well, but 
it is also available here.<br>
The <em>true/false</em> value represents whether the program will output the astrisks on a per-roll basis (true) or by percentage (false). Doing it by percentage 
will always result in (about) 100 astrisks being outputted while doing it on a per-roll basis will always output the same number of astrisks as the number inputted 
for how many times to roll. There are also minor differences in text to reflect these changes.

## Assignment Description (from Prof. Hilton)
Write a .NET console application using C# that simulates the rolling of two 6-sided dice. Use an
Array to keep track of the number of times that each combination is thrown. In other words,
keep track of how many times the combination of the two simulated dice is 2, how many times
the combination is 3, and so on, all the way up through 12.

Allow the user to choose how many times the “dice” will be thrown. Then, once you have the
number of rolls, pass that number to a second class that has a method that simulates the roll of
the dice for the number of times that the user specified. That method in the second class should
return the array containing the results. In the first class, use that array to print a histogram (using
the * character) that shows the total percentage each number was rolled. Each * will represent
1% of the total rolls.<br><br>

<strong>Sample session:</strong><br>
Welcome to the dice throwing simulator!<br>
How many dice rolls would you like to simulate? 1000<br>
DICE ROLLING SIMULATION RESULTS<br>
Each "*" represents 1% of the total number of rolls.<br>
Total number of rolls = 1000.

2: ***<br>
3: ***<br>
4: ***********<br>
5: ***********<br>
6: ********<br>
7: ******************<br>
8: ****************<br>
9: **********<br>
10: *************<br>
11: *****<br>
12: **<br>

Thank you for using the dice throwing simulator. Goodbye!


NOTE: Due to rounding issues and the fact that you cannot print a partial asterisk, your total
number of asterisks printed may not be exactly 100.
