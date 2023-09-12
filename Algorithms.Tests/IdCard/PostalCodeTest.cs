using Algorithms.IdCard;
namespace Algorithms.Tests.IdCard

{
    [TestClass]
    public class TestPostalCode
    {
        [TestMethod]
        [DataRow("H3S 1M8")]
        [DataRow("H3S 1G2")]
        public void TestIsValid(string value)
        {
            Assert.IsTrue(new PostalCode(value).IsValid());

        }
    }
}