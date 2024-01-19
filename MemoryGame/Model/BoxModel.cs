using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Model
{
    public class BoxModel
    {
        public int OriginalValue { get; set; }
        public int UserInput { get; set; }

        public BoxModel(int originalValue, int userInput) 
        {
            OriginalValue = originalValue;
            UserInput = userInput;
        }
    }
}
