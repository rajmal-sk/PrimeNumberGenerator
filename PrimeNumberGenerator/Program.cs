using System;
using System.Collections.Generic;

namespace PrimeNumberGenerator
{
    /// <summary>
    /// The main entry point of the Prime Number Generator application.
    /// This program allows users to generate prime numbers up to a specified limit
    /// using the Sieve of Eratosthenes algorithm.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main method that starts the execution of the program.
        /// It continuously prompts the user for input, generates prime numbers,
        /// and displays them until the user chooses to exit.
        /// </summary>
        /// <param name="args">Command-line arguments (not used in this application).</param>
        static void Main(string[] args)
        {
            // Create an instance of the SieveOfEratosthenes strategy for prime number generation.
            IPrimeGenerationStrategy sieveStrategy = new SieveOfEratosthenes();

            // Instantiate the PrimeNumberGenerator using the selected strategy.
            PrimeNumberGenerator primeGenerator = new PrimeNumberGenerator(sieveStrategy);

            // Infinite loop to keep the program running until the user decides to exit.
            while (true)
            {
                // Display a prompt to the user for input.
                Console.WriteLine("Enter the limit number to generate primes up to (or type 'quit' to exit):");

                // Read user input from the console.
                string input = Console.ReadLine();

                // Check if the user wants to quit the application.
                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("Exiting the program...");
                    break; // Exit the loop and terminate the program.
                }

                // Try to parse the user input as an integer.
                if (int.TryParse(input, out int limit) && limit > 1)
                {
                    // Generate prime numbers up to the specified limit.
                    List<int> primes = primeGenerator.GetPrimes(limit);

                    // Display the generated prime numbers.
                    PrimeDisplay.Display(primes);
                }
                else
                {
                    // Handle invalid input by displaying an error message.
                    Console.WriteLine("Invalid input. Please enter a positive integer greater than 1 or type 'quit' to exit.");
                }
            }
        }
    }
}