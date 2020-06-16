using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using FineSum;
using Assert = NUnit.Framework.Assert;

namespace FineSum
{
 
  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void MyTest()
    {
      Assert.AreEqual(8, Program.findSum(5));
      Assert.AreEqual(33, Program.findSum(10));
    }
  }
}