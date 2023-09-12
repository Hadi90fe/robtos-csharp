using Algorithms.IdCard;

namespace Algorithms.Tests.IdCard;



[TestClass]
public class NameTest
{
    [TestMethod]
    public void TestIsValid()
    {
        Assert.IsFalse(new Name("", "").IsValid()); //true
        Assert.IsFalse(new Name("bob", "r2d3").IsValid()); //true the last name contains digits
    }
}