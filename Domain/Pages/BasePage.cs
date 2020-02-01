using SeleniumTestFramework;
using SeleniumTestFramework.Interactions;

namespace Domain.Pages
{
    public class BasePage
    {
        public BaseInteractions Interactions { get; }
        public SeleniumNavigation Navigation { get; }
        public SeleniumElement Element { get; }
        public SeleniumButton Button { get; }
        public SeleniumIframe Iframe { get; }
        public SeleniumInput Input { get; }
        public SeleniumLabel Label { get; }
        public SeleniumSelect Select { get; }

        public BasePage()
        {
            Interactions = new BaseInteractions();
            Navigation = Interactions.Navigation;
            Element = Interactions.Element;
            Button = Interactions.Button;
            Iframe = Interactions.Iframe;
            Input = Interactions.Input;
            Label = Interactions.Label;
            Select = Interactions.Select;
        }
    }
}
