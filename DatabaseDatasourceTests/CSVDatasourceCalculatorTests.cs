namespace CSVDatasourceTests;

[TestClass]
public class CSVDatasourceCalculatorTests
{
    private Calculator _calculator = new Calculator();

    [TestMethod]
    [CSVDataSource(@"../../../../TestData/CalculatorData.csv")]
    public void AddNumbersUsingDataSource(int expected, int x, int y)
    {
        Assert.AreEqual(expected, _calculator.Add(x, y));
    }
}
