namespace NormalCalculatorTests;

[TestClass]
public class BadCalculatorTests
{
    private Calculator _calculator = new Calculator();

    [TestMethod]
    public void AddTenAndTwentyGivesThirty()
    {
        Assert.AreEqual(_calculator.Add(10, 20), 30);
    }

    [TestMethod]
    public void AddTwoAndEightGivesTen()
    {
        Assert.AreEqual(_calculator.Add(2, 8), 10);
    }

    [TestMethod]
    public void AddthreeAndSevenGivesTen()
    {
        Assert.AreEqual(_calculator.Add(3, 7), 10);
    }
}
