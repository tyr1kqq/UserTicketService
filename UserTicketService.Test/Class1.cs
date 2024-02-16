using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace UserTicketService.Tests
{
    [TestFixture]
    public class Class1
    {
        [SetUp]

        public void Setup()
        {

        }
       
        [Test]
        public void Test1()
        {
            ClassicAssert.True(100 == 100);
        }
    }
}