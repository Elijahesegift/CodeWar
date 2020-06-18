using System;
using Xunit;
using NUnit.Framework;
using Assert = Xunit.Assert;
using ReverseWords;


namespace ReverseWords
{
    

    [TestFixture]
    public class Tests
    {
        [Test]
        public void Example()
        {
            Assert.AreEqual("sihT si na !elpmaxe", Program.ReverseWords("This is an example!"));
        }
    }
}
