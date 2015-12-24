using Foundation;
using UIKit;

namespace ContiniousIntegrationiOS
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            Window = new UIWindow(UIScreen.MainScreen.Bounds);

            var mainScreen = new MainViewController();
            var navController = new UINavigationController(mainScreen);

            this.Window.RootViewController = navController;
            this.Window.MakeKeyAndVisible();

            return true;
        }
    }
}