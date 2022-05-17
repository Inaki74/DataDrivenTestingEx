namespace CSVDatasourceTests;

[TestClass]
public class CSVDatasourceCalculatorTests
{
    private Calculator _calculator = new Calculator();

    private TestContext _testContext;
    public TestContext TestContext
    {
        get { return _testContext; }
        set { _testContext = value; }
    }

    [TestMethod]
    [CSVDataSource(@"../../../../TestData/CalculatorData.csv")]
    public void AddNumbersUsingDataSource(int expected, int x, int y)
    {
        Assert.AreEqual(expected, _calculator.Add(x, y));
    }
}
