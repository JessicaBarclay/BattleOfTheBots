namespace BotExample
{
    using NUnit.Framework;

    [TestFixture]
    public class BotTest
    {
        [Test]
        public void NumberOfDynamite()
        {
            BotAIClass TestBot = new BotAIClass();
            TestBot.SetStartValues("TestOponent", 50, 100, 10);
            
            Assert.AreEqual(10, TestBot._dynamite);
        }
    }
}