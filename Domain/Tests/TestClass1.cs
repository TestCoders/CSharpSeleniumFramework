using Domain.Pages;
using NUnit.Framework;

namespace Domain.Tests
{
    public class TestClass1
    {
        [Test]
        public void TestMethod()
        {
            new BasePage().Navigation.NavigateTo(Globals.BaseUrl);
            Assert.True(true);
        }
    }
}
