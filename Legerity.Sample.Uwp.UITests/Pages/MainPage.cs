namespace Legerity.Sample.Uwp.UITests.Pages
{
    using Windows.Extensions;
    using Elements;
    using Legerity.Pages;
    using OpenQA.Selenium;

    public class MainPage : BasePage
    {
        protected override By Trait => ByExtensions.AutomationId("CustomControl");

        public MyCustomControl Control => this.WindowsApp.FindElement(this.Trait);

        public MainPage OpenControlFlyout()
        {
            this.Control.OpenFlyout();
            return this;
        }

        public MainPage CloseControlFlyout()
        {
            this.Control.CloseFlyout();
            return this;
        }
    }
}
