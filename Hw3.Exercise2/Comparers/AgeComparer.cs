﻿using Hw3.Exercise2.Models;

namespace Hw3.Exercise2.Comparers
{
    public class AgeComparer : IComparer<PlayerInfo>
    {
        public int Compare(PlayerInfo? x, PlayerInfo? y)
        {
            return x?.Age > y?.Age ? -1 : x?.Age < y?.Age ? 1 : 0;

        }
    }
}
