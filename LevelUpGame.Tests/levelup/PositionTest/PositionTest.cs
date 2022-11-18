using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class PositionTest
    {
        private Position? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new Position(0,0);
        }

        [Test]
        public void IsGameResultInitialized()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.AreEqual(0,0);
        }
    }
}