namespace PrimeNumberGenerator
{
    /// <summary>
    /// Prime number generator using the provided prime generation strategy.
    /// </summary>
    public class PrimeNumberGenerator
    {
        private readonly IPrimeGenerationStrategy _primeGenerationStrategy;

        /// <summary>
        /// Initializes a new instance of the <see cref="PrimeNumberGenerator"/> class.
        /// </summary>
        /// <param name="primeGenerationStrategy">The prime generation strategy to use.</param>
        public PrimeNumberGenerator(IPrimeGenerationStrategy primeGenerationStrategy)
        {
            _primeGenerationStrategy = primeGenerationStrategy ?? throw new ArgumentNullException(nameof(primeGenerationStrategy));
        }

        /// <summary>
        /// Generates a list of prime numbers up to the specified limit using the assigned strategy.
        /// </summary>
        /// <param name="limit">The upper bound up to which primes are generated.</param>
        /// <returns>A list of prime numbers <= limit.</returns>
        public List<int> GetPrimes(int limit)
        {
            return _primeGenerationStrategy.GeneratePrimes(limit);
        }
    }
}