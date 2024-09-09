using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ValidationOfPassword.Tests
{
    [TestClass]

public class PasswordCheckTests
{
#pragma warning disable CS8618
    private PasswordCheck _password;

    [TestInitialize]
    public void TestInitialize()
    {
        _password = new PasswordCheck();
    }

    [TestMethod]
    public void IsDigit_Method()
    {
        int result = _password.Checker("1337");
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void IsLower_Method()
    {
        int result = _password.Checker("parol1337");
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void IsUpper_Method()
    {
        int result = _password.Checker("Parol1337");
        Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void SpecialCharacter_Method()
    {
        int result = _password.Checker("Parol1337!");
        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void Length_Method()
    {
        int result = _password.Checker("Parol1337!!!!!!!!!!!!!");
        Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void ZeroCriteries_Method()
    {
        int result = _password.Checker("");
        Assert.AreEqual(0, result);
    }

    static void Main() {}
}

}
