using Tyuiu.BelovolovVS.Sprint2.Task7.V10.Lib;
namespace Tyuiu.BelovolovVS.Sprint2.Task7.V10.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCheckDotInShadeArea()
    {
        DataService ds = new DataService();
        double x = 0;
        double y = 1;
        bool res = ds.CheckDotInShadedArea(x, y);
        bool wait = true;
        Assert.AreEqual(res , wait);
    }
}