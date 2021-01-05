namespace Legerity.Sample.Uwp.UITests.Tests
{
    using NUnit.Framework;
    using Pages;
    using Shouldly;

    [TestFixture]
    public class MainPageTests : BaseTestFixture
    {
        private static MainPage MainPage { get; set; }

        /// <exception cref="T:Legerity.Exceptions.DriverLoadFailedException">Thrown if the application is null or the session ID is null once initialized.</exception>
        /// <exception cref="T:Legerity.Windows.Exceptions.WinAppDriverNotFoundException">Thrown if the WinAppDriver could not be found when running with <see cref="P:Legerity.Windows.WindowsAppManagerOptions.LaunchWinAppDriver" /> true.</exception>
        /// <exception cref="T:Legerity.Windows.Exceptions.WinAppDriverLoadFailedException">Thrown if the WinAppDriver failed to load when running with <see cref="P:Legerity.Windows.WindowsAppManagerOptions.LaunchWinAppDriver" /> true.</exception>
        [SetUp]
        public override void Initialize()
        {
            base.Initialize();
            MainPage = new MainPage();
        }

        [Test]
        public void CanOpenControlFlyout()
        {
            MainPage.OpenControlFlyout();
            MainPage.Control.FlyoutImage.ShouldNotBeNull();
        }

        [Test]
        public void CanCloseControlFlyout()
        {
            MainPage.OpenControlFlyout().CloseControlFlyout();
        }
    }
}
