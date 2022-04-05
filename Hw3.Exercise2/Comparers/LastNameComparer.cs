using Hw3.Exercise2.Models;

namespace Hw3.Exercise2.Comparers
{
    public class LastNameComparer : IComparer<PlayerInfo>
    {
        public int Compare(PlayerInfo? x, PlayerInfo? y)
        {

            return x?.LastName?.FirstOrDefault() > y?.LastName?.FirstOrDefault()
                ? -1
                : x?.LastName?.FirstOrDefault() < y?.LastName?.FirstOrDefault()
                    ? 1
                    : x?.LastName?.Skip(1).FirstOrDefault() > y?.LastName?.Skip(1).FirstOrDefault()
                                    ? -1
                                    : x?.LastName?.Skip(1).FirstOrDefault() < y?.LastName?.Skip(1).FirstOrDefault() ? 1 : 0;

        }
    }
}
