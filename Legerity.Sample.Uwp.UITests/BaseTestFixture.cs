namespace Legerity.Sample.Uwp.UITests
{
    using Windows;
    using Legerity;
    using NUnit.Framework;

    public abstract class BaseTestFixture
    {
        private const string AppId = "12f5fffe-664a-4267-b849-44026f2ac1ba_7mzr475ysvhxg!App";

        /// <exception cref="T:Legerity.Exceptions.DriverLoadFailedException">Thrown if the application is null or the session ID is null once initialized.</exception>
        /// <exception cref="T:Legerity.Windows.Exceptions.WinAppDriverNotFoundException">Thrown if the WinAppDriver could not be found when running with <see cref="P:Legerity.Windows.WindowsAppManagerOptions.LaunchWinAppDriver" /> true.</exception>
        /// <exception cref="T:Legerity.Windows.Exceptions.WinAppDriverLoadFailedException">Thrown if the WinAppDriver failed to load when running with <see cref="P:Legerity.Windows.WindowsAppManagerOptions.LaunchWinAppDriver" /> true.</exception>
        [SetUp]
        public virtual void Initialize()
        {
            AppManager.StartApp(
                new WindowsAppManagerOptions(AppId)
                {
                    DriverUri = "http://127.0.0.1:4723",
                    LaunchWinAppDriver = true
                });
        }

        [TearDown]
        public virtual void Cleanup()
        {
            AppManager.StopApp();
        }
    }
}