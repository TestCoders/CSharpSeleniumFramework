using OpenQA.Selenium;
using SeleniumTestFramework.Interactions;

namespace Domain.Pages.Components
{
    internal class HeaderComponent : BaseInteractions
    {
        #region elements
        private By BtnSignIn => By.ClassName("login");
        #endregion

        internal HeaderComponent(SeleniumInteractions interactions) : base(interactions)
        {
        }

        internal void ClickSignIn()
        {
            Button.Click(BtnSignIn);
        }
    }
}
