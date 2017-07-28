using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BotExample;


namespace BotExample.Tests
{
    [TestClass]
    public class BotTest
    {
        [TestMethod]
        public void NumberOfDynamite()
        {
            BotAIClass.SetStartValues("TestOponent", 50, 100, 10);

            Assert.AreEqual(10, BotAIClass._dynamite);
        }
    }
}