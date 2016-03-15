using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTest
{
    [TestMethod]
    public void Test()
    {
        int[] arr = { 1, 7, 6, 1 };
        int input = CountNumberAppears.CountAppears(arr, 1);
        Assert.AreEqual(2, input);
    }
}
