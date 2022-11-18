using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class CharacterTest
    {
        private Character? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new Character();
        }

        [Test]
        public void IsDefaultCharacterInitialized()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.IsNotNull(testObj.Name);
        }
        [Test]
        public void IsDefaultCharacterNameSet() {
            Assert.AreEqual(testObj.Name,"The Bankanator");
        }
    }
}