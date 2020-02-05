using NUnit.Framework;
using SeleniumTestFramework.Interactions;

namespace Domain.Tests
{
    public class TestSetUp
    {
        internal SeleniumInteractions Interactions { get; set; }

        [SetUp]
        public void SetUp()
        {
            Interactions = new SeleniumInteractions();
        }

        [TearDown]
        public void TearDown()
        {
            Interactions.EndDriver();
        }
    }
}
