using System;
using System.Collections.Generic;

namespace DiscGolfScore.Core
{
    public class ScoreCard
    {
        public int Id { get; set; }

        public string Location { get; set; }

        public int Holes { get; set; }

        public Dictionary<int, int> Scores { get; set; } 
    }
}
