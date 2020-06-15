using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using LongestString;
using Assert = NUnit.Framework.Assert;

namespace LongestStringTest
{
    [TestFixture]
    public static class TwoToOneTests
    {

        [Test]
        public static void test1()
        {
            Assert.AreEqual("aehrsty", TwoToOne.Longest("aretheyhere", "yestheyarehere"));
            Assert.AreEqual("abcdefghilnoprstu", TwoToOne.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
            Assert.AreEqual("acefghilmnoprstuy", TwoToOne.Longest("inmanylanguages", "theresapairoffunctions"));
        }
    }
}
