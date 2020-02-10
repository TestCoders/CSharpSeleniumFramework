using OpenQA.Selenium;
using SeleniumTestFramework.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Pages
{
    internal class AccountCreatePage : DomainBasePage
    {
        private By BtnGenderMale => By.Id("id_gender1");
        private By BtnGenderFemale => By.Id("id_gender2");
        private By InputFirstName => By.XPath("//* [@name='customer_firstname']");
        private By InputLastName => By.Id("customer_lastname");
        private By InputPassword => By.Id("passwd");
        private By SelectDay => By.Id("days");
        private By SelectMonth => By.Id("months");
        private By SelectYear => By.Id("years");
        private By InputAddressLineOne => By.Id("address1");
        private By InputAddressLineTwo => By.Id("address2");
        private By InputCity => By.Id("city");
        private By SelectState => By.Id("id_state");
        private By InputPostalCode => By.Id("postcode");
        private By InputPhoneMobile => By.Id("phone_mobile");
        private By BtnSubmit => By.Id("submitAccount");

            
        internal AccountCreatePage(SeleniumInteractions interactions) : base(interactions)
        {
        }

        public void FillInAccountInformation()
        {
            Button.Click(BtnGenderMale);
            Input.EnterText(InputFirstName, "Henkie");
            Input.EnterText(InputLastName, "Penkie");
            Input.EnterText(InputPassword, "Spermatankie");
            Select.SelectByIndex(SelectDay, new Random().Next(2, 27));
            Select.SelectByIndex(SelectMonth, new Random().Next(2, 14));
            Select.SelectByIndex(SelectYear, new Random().Next(25, 60));
            Input.EnterText(InputAddressLineOne, "GeileStrasse Eins");
            Input.EnterText(InputCity, "Supah Town");
            Input.EnterText(InputPhoneMobile, "09060611");
            Button.Click(BtnSubmit);
        }
    }
}
