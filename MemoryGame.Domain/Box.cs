using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Domain
{
    public class Box
    {
        public Box(int initialValue, List<int> position)
        {
            InitialValue = initialValue;
            Position = position;    
        }

        public List<int> Position { get; set; }
        public int InitialValue { get; set; }
    }
}
