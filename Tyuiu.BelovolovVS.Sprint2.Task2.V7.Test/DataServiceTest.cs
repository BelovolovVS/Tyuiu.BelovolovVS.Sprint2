namespace Tyuiu.BelovolovVS.Sprint2.Task2.V7.Test;
using Tyuiu.BelovolovVS.Sprint2.Task2.V7.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCheckInDotArea()
    {
        
        DataService ds = new DataService();
        int x = 4;
        int y = 4;
        
        bool res = ds.CheckDotInShadedArea(x, y);
        bool wait = true;
        
        Assert.AreEqual(res , wait);
    }
}