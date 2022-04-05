using Hw3.Exercise2.Models;
using Hw3.Exercise2.Comparers;

namespace Hw3.Exercise2
{
    public sealed class CsComparerApplication
    {
        /// <summary>
        /// CsCompare application return codes.
        /// </summary>
        public enum ReturnCode
        {
            Success = 0,
            InvalidArgs = -1
        }

        public ReturnCode Run(string[] args)
        {
            // TODO: Parse and validate the arguments and return result of the command.
            if (args is null || args.Length < 1)
            {
                return ReturnCode.InvalidArgs;
            }
            IComparer<PlayerInfo>? comparer;
            switch (args[0])
            {
                case "age":
                    comparer = new AgeComparer();
                    break;
                case "lastname":
                    comparer = new LastNameComparer();
                    break;
                case "rank":
                    comparer = new PlayerRankComparer();
                    break;
                default:
                    return ReturnCode.InvalidArgs;
            };

            var players = CsComparerService.Compare(comparer);
            Console.WriteLine(string.Join("\n", players));

            return ReturnCode.Success;
        }
    }
}
