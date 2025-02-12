namespace PrimeNumberGenerator
{
    public class SieveOfEratosthenes : IPrimeGenerationStrategy
    {
        /// <summary>
        /// Generates a list of prime numbers up to the specified limit using the Sieve of Eratosthenes algorithm.
        /// </summary>
        /// <param name="limit">The upper bound up to which primes are generated.</param>
        /// <returns>A list of prime numbers <= limit.</returns>
        public List<int> GeneratePrimes(int limit)
        {
            if (limit < 2)
            {
                return new List<int>(); // No primes below 2
            }

            bool[] sieve = InitializeSieve(limit);
            MarkEvenNumbers(sieve, limit);
            MarkMultiplesOfPrimes(sieve, limit);
            return CollectPrimes(sieve, limit);
        }

        /// <summary>
        /// Initializes the sieve array with assumptions that all numbers are prime.
        /// </summary>
        /// <param name="limit">The upper bound up to which primes are generated.</param>
        /// <returns>A boolean array representing the sieve of primes.</returns>
        private bool[] InitializeSieve(int limit)
        {
            bool[] sieve = new bool[limit + 1];
            for (int i = 0; i <= limit; i++)
            {
                sieve[i] = true; // Assume all numbers are prime
            }
            sieve[0] = sieve[1] = false; // 0 and 1 are not prime
            return sieve;
        }

        /// <summary>
        /// Marks all even numbers greater than 2 as non-prime.
        /// </summary>
        /// <param name="sieve">The sieve array where prime numbers are marked.</param>
        /// <param name="limit">The upper bound up to which primes are generated.</param>
        private void MarkEvenNumbers(bool[] sieve, int limit)
        {
            for (int j = 4; j <= limit; j += 2)
            {
                sieve[j] = false;
            }
        }

        /// <summary>
        /// Marks the multiples of prime numbers as non-prime in the sieve array.
        /// </summary>
        /// <param name="sieve">The sieve array where prime numbers are marked.</param>
        /// <param name="limit">The upper bound up to which primes are generated.</param>
        private void MarkMultiplesOfPrimes(bool[] sieve, int limit)
        {
            for (int i = 3; i <= Math.Sqrt(limit); i += 2)
            {
                if (sieve[i]) // If i is prime
                {
                    for (int j = i * i; j <= limit; j += 2 * i) // Mark multiples of i as non-prime
                    {
                        sieve[j] = false;
                    }
                }
            }
        }

        /// <summary>
        /// Collects the prime numbers from the sieve array.
        /// </summary>
        /// <param name="sieve">The sieve array where prime numbers are marked.</param>
        /// <param name="limit">The upper bound up to which primes are generated.</param>
        /// <returns>A list of prime numbers up to the limit.</returns>
        private List<int> CollectPrimes(bool[] sieve, int limit)
        {
            List<int> primes = new List<int> { 2 }; // 2 is always prime
            for (int i = 3; i <= limit; i += 2)
            {
                if (sieve[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }
    }
}