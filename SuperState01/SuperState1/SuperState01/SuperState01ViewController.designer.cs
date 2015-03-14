// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace SuperState01
{
	[Register ("SuperState01ViewController")]
	partial class SuperState01ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
<<<<<<< HEAD
=======
		UILabel lbl { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tblRemoved { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
>>>>>>> 42324109af273a3c3c0d53f499f54b42db18df2f
		UITableView tblView { get; set; }

		void ReleaseDesignerOutlets ()
		{
<<<<<<< HEAD
=======
			if (lbl != null) {
				lbl.Dispose ();
				lbl = null;
			}
			if (tblRemoved != null) {
				tblRemoved.Dispose ();
				tblRemoved = null;
			}
>>>>>>> 42324109af273a3c3c0d53f499f54b42db18df2f
			if (tblView != null) {
				tblView.Dispose ();
				tblView = null;
			}
		}
	}
}
