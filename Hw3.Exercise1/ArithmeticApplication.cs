namespace Hw3.Exercise1
{
    public sealed class ArithmeticApplication
    {
        /// <summary>
        /// Arithmetic application return codes.
        /// </summary>
        public enum ReturnCode
        {
            Success = 0,
            InvalidArgs = -1,
            Exception = -2
        }

        public ReturnCode Run(string[] args)
        {
            // TODO: Parse and validate the arguments and convert it to the numbers.
            try
            {
                if (args is null)
                    return ReturnCode.InvalidArgs;

                var str = string.Join(",", args).Split(",", StringSplitOptions.RemoveEmptyEntries);

                var parse = str.Select(s => int.TryParse(s, out var res)).ToList();

                if (parse.Any(s => s == false) || parse.Count < 1)
                    return ReturnCode.InvalidArgs;

                var intList = Array.ConvertAll(str, int.Parse).ToList();

                var result = ArithmeticProcessor.Calculate(intList);

                Console.WriteLine(string.Join(" ", result));

                return ReturnCode.Success;
            }
            catch (OverflowException)
            {
                return ReturnCode.Exception;
            }

        }

    }
}
