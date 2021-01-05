namespace Legerity.Sample.Uwp.Controls
{
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Automation.Peers;
    using Windows.UI.Xaml.Controls;
    using Control = MADE.UI.Controls.Control;

    [TemplatePart(Name = CloseFlyoutButtonPart, Type = typeof(Button))]
    [TemplatePart(Name = FlyoutPart, Type = typeof(Flyout))]
    public class MyCustomControl : Control
    {
        private const string CloseFlyoutButtonPart = "CloseFlyoutButton";
        private const string FlyoutPart = "Flyout";

        private Button closeFlyoutButton;
        private Flyout flyout;

        public MyCustomControl()
        {
            this.DefaultStyleKey = typeof(MyCustomControl);
        }

        protected override AutomationPeer OnCreateAutomationPeer()
        {
            return new MyCustomControlAutomationPeer(this);
        }

        protected override void OnApplyTemplate()
        {
            if (this.closeFlyoutButton != null)
            {
                this.closeFlyoutButton.Click -= this.OnCloseFlyoutButtonClicked;
            }

            base.OnApplyTemplate();

            this.closeFlyoutButton = this.GetChildView<Button>(CloseFlyoutButtonPart);
            this.flyout = this.GetChildView<Flyout>(FlyoutPart);

            if (this.closeFlyoutButton != null)
            {
                this.closeFlyoutButton.Click += this.OnCloseFlyoutButtonClicked;
            }
        }

        private void OnCloseFlyoutButtonClicked(object sender, RoutedEventArgs e)
        {
            this.flyout?.Hide();
        }
    }
}