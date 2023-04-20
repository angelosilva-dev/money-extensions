namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToint()
    {
        decimal valor = 278.98M;
        var cents = valor.ToCents();

        Assert.AreEqual(27898, cents);
    }
}