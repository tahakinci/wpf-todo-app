using MemoryGame.Domain;
using NUnit.Framework;
using Shouldly;

namespace MemoryGameDomainTests
{
    public class GameManagerTest
    {
       
        [Test]
        public  void IsBoxesCreated()
        {
            var gameManager = new GameManager();
            gameManager.StartRound(3, 2000);
            gameManager.BoxManager.BoxList.Count.ShouldBe(3);
        }

        [Test]
        public void IsUserClickRightOrder ()
        {
            var gameManager = new GameManager();
            gameManager.StartRound(3, 2000);
            for (int i = 0; i < 3; i++)
            {
                gameManager.PlayerAction();
            }
            gameManager.CheckResult(gameManager.AnswerList).ShouldBeTrue();
        }

        //public void MustFailWhenPlayerClickWrongOrder()
        //{
            
        //}

        [Test]
        public void WhenAllAnswerRightLevelUps ()
        {
            var gameManager = new GameManager();
            gameManager.StartRound(3, 2000);
            for(int i = 0; i<3 ; i++)
            {
                gameManager.PlayerAction();
            }
            gameManager.Level.ShouldBe(4);

        }
    }
}
