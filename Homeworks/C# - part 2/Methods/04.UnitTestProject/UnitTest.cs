using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTest
{
    [TestMethod]
    public void TestMethod()
    {
        int[] array = { 1, 7, 6, 1 };
        int input = CountNumberApears.CountAppears(array, 1);
        Assert.AreEqual(2, input);
    }
}
