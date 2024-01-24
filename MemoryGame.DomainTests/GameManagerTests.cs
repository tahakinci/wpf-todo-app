using Shouldly;
using MemoryGame.Domain;
using NUnit.Framework;

namespace MemoryGame.DomainTests
{
    public class GameManagerTests
    {
        [Test]
        public void SetBoxesTest ()
        {
            GameManager manager = new GameManager ();
            manager.SetBoxes();
            manager.BoxList.Count
          .ShouldBe(answer);
        }
    }
}
