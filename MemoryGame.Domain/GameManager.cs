using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Domain
{
    public class GameManager
    {
        public int Clicks { get; set; }
        public List<bool> AnswerList { get; set; }
        public BoxManager BoxManager { get; set; }
        public Game Game { get; set; }
        public int Difficulty { get; set; }
        public int Level{ get; set; }
        public GameManager()
        {
            Clicks = 0;
            IsBoxVisible = true;
            AnswerList = new List<bool>();
        }
        
        public bool IsBoxVisible { get; set; }

        public async void StartRound(int level, int difficulty )
        {

            var Game = new Game(level, difficulty);
            Level = Game.Level;
            Difficulty = Game.Difficulty;
            // her tur başında cevap listesi silinir
            AnswerList.Clear();
            BoxManager = new BoxManager();
            BoxManager.SetBoxes(Level);
            await Task.Delay(Difficulty);
            IsBoxVisible = false;
        }

        public bool CheckResult (List<bool> answerList) 
        {
            return answerList.All(a => a == true);
        }

        public void NextRound()
        {
            // TODO: Validation yaz level sonsuza kadar gitmesin
            // TODO: Direkt Game.Level'ı değiştirmek yerine daha düzgün yap.
            Level++;
            StartRound(Level, Difficulty);
        }

        public void GameOver()
        {
            
        }

        public void PlayerAction(int value)
        {
             Clicks++;
            if(Clicks < BoxManager.BoxList.Count)
            {
                bool IsClickedRigthBox = value == Clicks;
                AnswerList.Add(IsClickedRigthBox);
            }
            else if(Clicks == BoxManager.BoxList.Count)
            {
                bool IsClickedRigthBox = value == Clicks;
                AnswerList.Add(IsClickedRigthBox);
                var IsCorrect = CheckResult(AnswerList);
                if(IsCorrect)
                {
                    NextRound();
                }
                else
                {
                    GameOver();
                }
            }
        }

    }
}
