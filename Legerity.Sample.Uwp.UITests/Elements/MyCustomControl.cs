namespace Legerity.Sample.Uwp.UITests.Elements
{
    using Windows.Elements;
    using Windows.Elements.Core;
    using Windows.Extensions;
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Windows;

    public class MyCustomControl : WindowsElementWrapper
    {
        public MyCustomControl(WindowsElement element) : base(element)
        {
        }

        public Button OpenFlyoutButton => this.Element.FindElementByAutomationId("OpenFlyoutButton");

        public WindowsElement Flyout => this.Driver.FindElementByAutomationId("Flyout");

        public Button CloseFlyoutButton => this.Flyout.FindElementByAutomationId("CloseFlyoutButton");

        public AppiumWebElement FlyoutImage => this.Flyout.FindElementByAutomationId("FlyoutImage");

        /// <summary>
        /// Allows conversion of a <see cref="WindowsElement"/> to the <see cref="MyCustomControl"/> without direct casting.
        /// </summary>
        /// <param name="element">
        /// The <see cref="WindowsElement"/>.
        /// </param>
        /// <returns>
        /// The <see cref="MyCustomControl"/>.
        /// </returns>
        public static implicit operator MyCustomControl(WindowsElement element)
        {
            return new MyCustomControl(element);
        }

        /// <summary>
        /// Allows conversion of a <see cref="AppiumWebElement"/> to the <see cref="MyCustomControl"/> without direct casting.
        /// </summary>
        /// <param name="element">
        /// The <see cref="AppiumWebElement"/>.
        /// </param>
        /// <returns>
        /// The <see cref="MyCustomControl"/>.
        /// </returns>
        public static implicit operator MyCustomControl(AppiumWebElement element)
        {
            return new MyCustomControl(element as WindowsElement);
        }


        public void OpenFlyout()
        {
            this.OpenFlyoutButton.Click();
        }

        public void CloseFlyout()
        {
            this.CloseFlyoutButton.Click();
        }
    }
}
