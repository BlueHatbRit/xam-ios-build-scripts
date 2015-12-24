// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ContiniousIntegrationiOS
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		UIKit.UIButton CheckerButton { get; set; }

		[Outlet]
		UIKit.UITextField CheckerTextField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CheckerButton != null) {
				CheckerButton.Dispose ();
				CheckerButton = null;
			}

			if (CheckerTextField != null) {
				CheckerTextField.Dispose ();
				CheckerTextField = null;
			}
		}
	}
}
