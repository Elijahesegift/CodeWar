using System;
using Codewar5;
using NUnit.Framework;

namespace Codewar5
{   
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void CorrectTests()
        {
            Assert.AreEqual("LONDON", Codewar5.Correct("L0ND0N"));
            Assert.AreEqual("DUBLIN", Codewar5.Correct("DUBL1N"));
            Assert.AreEqual("SINGAPORE", Codewar5.Correct("51NGAP0RE"));
            Assert.AreEqual("BUDAPEST", Codewar5.Correct("BUDAPE5T"));
            Assert.AreEqual("PARIS", Codewar5.Correct("PAR15"));
        }
    }
}
