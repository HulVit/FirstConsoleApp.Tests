using NUnit.Framework;
using CodeJam;

namespace FirstConsoleApp.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        System.Console.WriteLine("=== Test started ===");
    }

    [Test]
    public void incomeCalculation()
    {
        Employee epl = new Employee("Vitaly", "Hulevich", 7, 10);
        int income = epl.getIncomeSum(2000);

        Assert.AreEqual(2200, income, "Income value was calculated wrong!");
        string str = "";
        Code.NotNullNorEmpty(str, nameof (str));
    }
}