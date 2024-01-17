using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fun
{
    internal class playGame
    {
        //concerns with public??
        public int numRolls;
        public int[] rollSums;

        //built-in method 
        private Random rand;

        //constructor
        public playGame(int numRolls) 
        {
            this.numRolls = numRolls;
            this.rollSums = new int[11];
            /* This array will store the amount of times each sum is rolled, 2-12,
             essentially there are 11 potential numbers to be rolled*/
            rand = new Random();

            rollDice();

        }
        //take out static because we want it used on program.cs
        private void rollDice()
        {
            for (int i = 0; i < numRolls; i++) //pass the given input number here - 
            {
                //can I just make one "die" that is 1-13? or do I have to include both dice 
                int firstDie = rand.Next(1, 7); // First dice roll
                int secondDie = rand.Next(1, 7); // Second dice roll
                int sum = firstDie + secondDie; // Sum of both rolls

                rollSums[sum - 2]++;
                /*If I roll a 6, then rollSums[4] will hold the "6" count, because 
                you are holding numbers between 2-12 within the array, and the array starts 
                at [0]
                [0] is 2, [1] is 3, [2] is 4, etc. */
            }
        }
    }
}
