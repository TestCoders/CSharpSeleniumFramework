using OpenQA.Selenium;
using SeleniumTestFramework.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Pages
{
    internal class AuthenticationPage : DomainBasePage
    {
        private By InputEmailCreate => By.Id("email_create");
        private By BtnSubmitCreate => By.Id("SubmitCreate");

        internal AuthenticationPage(SeleniumInteractions interactions) : base(interactions)
        {
        }

        internal void CreateAccount()
        {
            var email = GenerateEmailAddress();
            Input.EnterText(InputEmailCreate, email);
            Button.Click(BtnSubmitCreate);
        }

        private string GenerateEmailAddress()
        {
            var rdm = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            var randomString = new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[rdm.Next(s.Length)]).ToArray());

            return randomString += "@mailinator.com";
        }
    }
}
