using System.Collections.Generic;

namespace PrimeNumberGenerator
{
    /// <summary>
    /// Defines a strategy for generating prime numbers up to a given limit.
    /// </summary>
    public interface IPrimeGenerationStrategy
    {
        /// <summary>
        /// Generates a list of prime numbers up to the specified limit.
        /// </summary>
        /// <param name="limit">The upper bound (inclusive) for generating prime numbers.</param>
        /// <returns>A list of prime numbers up to the specified limit.</returns>
        List<int> GeneratePrimes(int limit);
    }
}