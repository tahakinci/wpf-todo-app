//using MemoryGame.Domain;
//using NUnit.Framework;
//using Shouldly;

//namespace MemoryGameDomainTests
//{
//    public class BoxManagerTests
//    {
//        [Test]
//        public void IsBoxCreated([Range(3, 10)] int level)
//        {
//            BoxManager manager = new BoxManager();
//            manager.NewGame(level);

//            manager.BoxList.Count
//                .ShouldBe(level);
//        }

//        public void IsBoxContainValue([Range(3, 10)] int level)
//        {
//            BoxManager manager = new BoxManager();
//            manager.NewGame(level);
//            var ValueList = manager.BoxList.Select(b => b.InitialValue).ToList();
//            var ValueContentList = manager.BoxList.All(b => b.InitialValue == level);
//            ValueContentList.ShouldBeTrue();
//            ValueList.Count.ShouldBe(level);
//        }

//        [Test]
//        public void BoxPositionTest([Range(3, 10)] int level) 
//        {
//            BoxManager manager = new BoxManager();
//            manager.NewGame(level);
//            var positionList = manager.BoxList.Select(x => x.Position).ToList();
//            positionList.Count.ShouldBe(level);
//        }

//        [Test]
//        public void IsEachPositionUniq([Range(3, 10)] int level)
//        {
//            BoxManager manager = new BoxManager();
//            manager.NewGame(level);
//            var positionList = manager.BoxList.Select(x => x.Position).ToList();
//            positionList.All(p => p.Distinct().Any()).ShouldBeTrue();

//        }
//    }
//}
