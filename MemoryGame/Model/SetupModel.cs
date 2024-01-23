using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Model
{
    public class SetupModel
    {

        public SetupModel(int level, string difficulty)
        {
            Level = level;
            Difficulty = difficulty;
        }

        public int Level { get; set; }
        public string Difficulty { get; set; }
    }
}
