using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Domain
{
    public class Game
    {
        public Game(int level, int difficulty)
        {
            Level = level;
            Difficulty = difficulty;
        }
        public int Level { get; set; }
        public int Difficulty { get; set; }
    }
}
