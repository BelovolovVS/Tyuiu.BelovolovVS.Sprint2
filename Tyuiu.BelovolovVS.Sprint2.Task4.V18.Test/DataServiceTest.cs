using Tyuiu.BelovolovVS.Sprint2.Task4.V18.Lib;
namespace Tyuiu.BelovolovVS.Sprint2.Task4.V18.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCondition1()
    {
        DataService ds = new DataService();
        double x = 1;
        double y = 10;
        double res = ds.Calculate(x, y);
        double wait = 6;
        Assert.AreEqual(res, wait);

    }
    [TestMethod]
    public void ValidCondition2()
    {
        DataService ds = new DataService();
        double x = 2;
        double y = 0;
        double res = ds.Calculate(x, y);
        double wait = 1.5;
        Assert.AreEqual(res, wait);
    }
}