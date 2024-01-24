using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace MemoryGame.Domain
{
    public class BoxManager
    {
        public BoxManager()
        {
            BoxList = [];
            LocationList = new List<List<int>>(); ;
            Level = 3;
        }
        public int Level { get; set; }
        public List<List<int>> LocationList { get; set; }
        public List<Box> BoxList { get; set; }

        public void NewGame(int level)
        {
            Level = level;
            SetBoxes(level);
        }
        public void SetBoxes(int level)
        {
            BoxList.Clear();
            LocationList.Clear();
            for (int i = 1; i <= level; i++)
            {
            Generate:
                var positionList = GenerateRandomList();
                bool isOccupated = LocationList.Any(l => l.SequenceEqual(positionList));
                if (!isOccupated)
                {
                    BoxList.Add(new Box(i,positionList));
                    LocationList.Add(positionList);
                }
                else goto Generate;
            }
        }

        private List<int> GenerateRandomList()
        {
            int Column = new Random().Next(0, 12);
            int Row = new Random().Next(1, 6);
            return new List<int>() { Column, Row };
        }
    }
}
