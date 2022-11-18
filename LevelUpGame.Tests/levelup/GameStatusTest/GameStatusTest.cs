using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class GameStatusTest
    {
        private GameStatus? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameStatus;
        }

        [Test]
        public void IsGameResultInitialized()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.AreEqual(testObj.ToString);
        }
    }
}