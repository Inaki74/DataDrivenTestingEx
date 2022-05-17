namespace NormalCalculatorTests;

[TestClass]
public class GoodCalculatorTests
{
    private Calculator _calculator = new Calculator();

    [DataTestMethod]
    [DataRow(3, 1, 2)]
    [DataRow(6, 2, 4)]
    [DataRow(9, 3, 6)]
    [DataRow(1, 0, 1)]
    public void AddTests(int expected, int x, int y)
    {
        Assert.AreEqual(expected, _calculator.Add(x, y));
    }
}
