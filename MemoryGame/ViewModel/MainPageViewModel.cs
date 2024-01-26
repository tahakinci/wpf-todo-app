using MemoryGame.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.ViewModel
{
    public class MainPageViewModel
    {
        public MainPageViewModel(GameManager gameManager)
        {
            GameManager = gameManager;
            BoxList = GameManager.BoxManager.BoxList;
        }
        public List<Box> BoxList { get; set; }
        public GameManager GameManager { get; set; }



    }
}
