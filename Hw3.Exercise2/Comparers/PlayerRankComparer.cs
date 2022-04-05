using Hw3.Exercise2.Models;

namespace Hw3.Exercise2.Comparers
{
    public class PlayerRankComparer : IComparer<PlayerInfo>
    {
        public int Compare(PlayerInfo? x, PlayerInfo? y)
        {
            return x?.Rank > y?.Rank ? -1 : x?.Rank < y?.Rank ? 1 : 0;
        }
    }
}
