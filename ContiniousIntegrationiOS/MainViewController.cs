using System;

using UIKit;

namespace ContiniousIntegrationiOS
{
    public partial class MainViewController : UIViewController
    {
        public MainViewController()
            : base("MainViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.CheckerButton.TouchUpInside += OnCheckerButtonPressed;
        }

        private void OnCheckerButtonPressed(object sender, EventArgs e)
        {
            this.CheckerTextField.Text = "Yep, it's working";
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


