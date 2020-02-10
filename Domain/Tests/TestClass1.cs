using Domain.Pages;
using NUnit.Framework;
using System.Threading;

namespace Domain.Tests
{
    [Parallelizable]
    public class TestClass1 : TestSetUp
    {
        [Test]
        public void TestClass1Method1()
        {
            new DomainBasePage(Interactions).Navigation.NavigateTo(Globals.BaseUrl);
            new DomainBasePage(Interactions).Header.ClickSignIn();
            new AuthenticationPage(Interactions).CreateAccount();
            new AccountCreatePage(Interactions).FillInAccountInformation();
            Thread.Sleep(5000);
            Assert.True(true);
        }

        [Test]
        public void TestClass1Method2()
        {
            new DomainBasePage(Interactions).Navigation.NavigateTo(Globals.BaseUrl);
            Assert.True(true);
        }
    }
}
