using Domain.Pages.Components;
using SeleniumTestFramework.Interactions;

namespace Domain.Pages
{
    internal class DomainBasePage : BaseInteractions
    {
        internal HeaderComponent Header { get; }

        internal DomainBasePage(SeleniumInteractions interactions) : base(interactions)
        {
            Header = new HeaderComponent(interactions);
        }
    }
}
