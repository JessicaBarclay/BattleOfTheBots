using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotExample;
using NUnit.Framework;

namespace BotAITests
{
    [TestFixture]
    public class BotAIClassTests
    {
        [Test]
        public void CanParseStringIntoMoveAndGetStringOutAgain()
        {
            Assert.AreEqual(Move.Parse("ROCK").ToString(), "ROCK");
        }
    }
}
