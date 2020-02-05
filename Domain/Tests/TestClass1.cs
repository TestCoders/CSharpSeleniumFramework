﻿using Domain.Pages;
using NUnit.Framework;

namespace Domain.Tests
{
    [Parallelizable]
    public class TestClass1 : TestSetUp
    {
        [Test]
        public void TestClass1Method1()
        {
            new DomainBasePage(Interactions).Navigation.NavigateTo(Globals.BaseUrl);
            new DomainBasePage(Interactions).Header.ClickSignInButton();
            Assert.True(true);
        }

        [Test]
        public void TestClass1Method2()
        {
            new DomainBasePage(Interactions).Navigation.NavigateTo(Globals.BaseUrl);
            new DomainBasePage(Interactions).Header.ClickSignInButton();
            Assert.True(true);
        }
    }
}
