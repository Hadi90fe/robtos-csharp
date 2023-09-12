using Algorithms.IdCard;

namespace Algorithms.Tests.IdCard
{
    [TestClass]
    public class TestTelephonNumber
    {
        [TestMethod]
        public void TestIsValid()
        {
            Assert.IsFalse(new TelephonNumber("2312312312").IsValid());
        }
    }
}