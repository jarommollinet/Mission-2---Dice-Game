using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");

        // Prompt for number of silumated rolls
        Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        // Instance for DiceRollSimulator class
        Mission_2___Jarom_Mollinet.DiceRollSimulator diceRollSimulator = new Mission_2___Jarom_Mollinet.DiceRollSimulator();

        // Call the SimulateDiceRolls method
        int[] results = diceRollSimulator.SimulateDiceRolls(numberOfRolls);

        // Display results
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numberOfRolls}.");

        for (int i = 2; i <= 12; i++)
        {
            int percentage = (results[i] * 100) / numberOfRolls;
            string asterisks = new string('*', percentage);
            Console.WriteLine($"{i}: {asterisks}");
        }

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}
