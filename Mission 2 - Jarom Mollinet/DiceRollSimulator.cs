using System;
using System.Collections.Generic;

namespace Mission_2___Jarom_Mollinet
{
    internal class DiceRollSimulator
    {
        private Random random = new Random();

        public int[] SimulateDiceRolls(int numberOfRolls)
        {
            // Initialize an array to store results
            int[] results = new int[13]; 

            for (int i = 0; i < numberOfRolls; i++)
            {
                // First and second rolls
                int dice1 = random.Next(1, 7); 
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;

                // Auto-increment the sum
                results[sum]++; 
            }

            return results;
        }
    }
}
