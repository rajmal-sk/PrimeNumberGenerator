namespace PrimeNumberGenerator
{
    /// <summary>
    /// Handles displaying a list of prime numbers.
    /// </summary>
    public static class PrimeDisplay
    {
        /// <summary>
        /// Displays the given list of prime numbers to the console.
        /// </summary>
        /// <param name="primes">List of prime numbers to display.</param>
        public static void Display(List<int> primes)
        {
            if (primes == null || primes.Count == 0)
            {
                Console.WriteLine("No prime numbers to display.");
                return;
            }

            Console.WriteLine("Prime numbers:");
            Console.WriteLine(string.Join(" ", primes));
        }
    }
}