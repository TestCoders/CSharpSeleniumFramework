using SeleniumTestFramework.Interactions;

namespace Domain.Pages
{
    internal class BaseInteractions
    {
        #region interactables
        internal SeleniumInteractions Interactions { get; set; }
        internal SeleniumElement Element { get; set; }
        internal SeleniumButton Button { get; set; }
        internal SeleniumIframe Iframe { get; set; }
        internal SeleniumInput Input { get; set; }
        internal SeleniumLabel Label { get; set; }
        internal SeleniumSelect Select { get; set; }
        internal SeleniumNavigation Navigation { get; set; }
        #endregion

        internal BaseInteractions(SeleniumInteractions interactions)
        {
            Interactions = interactions;
            Element = Interactions.Element;
            Button = Interactions.Button;
            Iframe = Interactions.Iframe;
            Input = Interactions.Input;
            Label = Interactions.Label;
            Select = Interactions.Select;
            Navigation = Interactions.Navigation;
        }
    }
}
