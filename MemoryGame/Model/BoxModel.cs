using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MemoryGame.Model
{
    public class BoxModel
    {
        public int Id { get; set; }
        public int OriginalValue { get; set; }
        public List<int> Position { get; set; }

        public BoxModel(int originalValue, List<int> position, int id) 
        {
            OriginalValue = originalValue;
            Position = position;
            Id = id;
        }
    }
}
