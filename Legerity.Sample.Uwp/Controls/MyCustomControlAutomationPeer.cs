namespace Legerity.Sample.Uwp.Controls
{
    using Windows.UI.Xaml.Automation.Peers;

    /// <summary>
    /// Defines a framework element automation peer for the <see cref="MyCustomControl"/> control.
    /// </summary>
    public class MyCustomControlAutomationPeer : FrameworkElementAutomationPeer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyCustomControlAutomationPeer"/> class.
        /// </summary>
        /// <param name="owner">
        /// The <see cref="MyCustomControl" /> that is associated with this <see cref="AutomationPeer"/>.
        /// </param>
        public MyCustomControlAutomationPeer(MyCustomControl owner)
            : base(owner)
        {
        }

        private MyCustomControl OwningElement => this.Owner as MyCustomControl;

        /// <summary>
        /// Gets the control type for the element that is associated with the UI Automation peer.
        /// </summary>
        /// <returns>The control type.</returns>
        protected override AutomationControlType GetAutomationControlTypeCore()
        {
            return AutomationControlType.Custom;
        }

        protected override string GetClassNameCore()
        {
            return this.Owner.GetType().Name;
        }

        protected override string GetNameCore()
        {
            string name = string.Empty;

            if (string.IsNullOrEmpty(name))
            {
                name = base.GetNameCore();
            }

            if (this.OwningElement != null)
            {
                name = this.OwningElement.Name;
            }

            if (string.IsNullOrEmpty(name))
            {
                name = this.GetClassName();
            }

            return name;
        }
    }
}