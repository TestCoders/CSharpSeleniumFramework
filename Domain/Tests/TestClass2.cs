using Domain.Pages;
using NUnit.Framework;

namespace Domain.Tests
{
    [Parallelizable]
    public class TestClass2 : TestSetUp
    {
        [Test]
        public void TestClass2Method1()
        {
            new DomainBasePage(Interactions).Navigation.NavigateTo(Globals.BaseUrl);
            Assert.True(true);
        }

        [Test]
        public void TestClasss2Method2()
        {
            new DomainBasePage(Interactions).Navigation.NavigateTo(Globals.BaseUrl);
            Assert.True(true);
        }
    }
}
