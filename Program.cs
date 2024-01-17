//hailey bronson, section 3 (test commit change)
//for when you need to reference other classes 
using C_Fun;
internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the dice throwing stimulator!");

        //Allow the user to choose how many times the “dice” will be thrown
        System.Console.WriteLine("How many dice rolls would you like to simulate ?");

        /*Then, once you have the
        number of rolls, pass that number to a second class that has a method that simulates the roll of
        the dice for the number of times that the user specified.*/
        int numRolls = int.Parse(System.Console.ReadLine());
        /*create as normal new variable and then pass into the class you will reference
        as you instantiate the object*/

        // Instantiating the object with the number of rolls
        playGame pg = new playGame(numRolls);
        printHistogram(pg.rollSums, numRolls);

        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }

    /*In the first class, use that array to print a histogram (using
    the * character) that shows the total percentage each number was rolled. Each * will represent
    1% of the total rolls. */
    private static void printHistogram(int[] rollSums, int totalRolls)
    {
        System.Console.WriteLine("Dice Roll Histogram:");
        for (int i = 0; i < rollSums.Length; i++)
        {
            System.Console.Write($"{i + 2}: ");
            int percentage = (rollSums[i] * 100) / totalRolls;
            for (int j = 0; j < percentage; j++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }

}