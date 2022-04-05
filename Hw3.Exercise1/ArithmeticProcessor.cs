namespace Hw3.Exercise1
{
    public static class ArithmeticProcessor
    {
        /// <summary>
        /// Calculates numbers by algorithm.
        /// </summary>
        /// <param name="numbers">Collection of numbers.</param>
        /// <returns>
        /// Returns <c>IEnumerable</c> of sorted numbers. 
        /// </returns>
        /// <exception cref="ArgumentNullException">Sequence is null.</exception>

        public static IEnumerable<int> Calculate(List<int> numbers)
        {
            if (numbers is null)
                throw new ArgumentNullException(nameof(numbers));

            var pairedIndex = numbers.Select((v, i) => new { Value = v, Index = i })
                .Where(n => n.Index % 2 == 0)
                .Select(n => checked(n.Value * 2)).ToList();

            var unpairedIndex = numbers.Select((v, i) => new { Value = v, Index = i })
                .Where(n => n.Index % 2 != 0)
                .Select(n => checked(n.Value - 10)).ToList();

            var result = pairedIndex.Concat(unpairedIndex).Distinct().OrderBy(result => result);
            return result;

        }
    }
}
