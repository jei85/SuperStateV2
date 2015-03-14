using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace SuperState01
{
	public class TableSource : UITableViewSource{
		#region implemented abstract members of UITableViewSource
		public List<int> removedItems = new List<int>();



		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			int rowIndex = indexPath.Row;
			UITableViewCell cell = tableView.DequeueReusableCell (this.cellID);
			if (cell == null)
				cell = new UITableViewCell (UITableViewCellStyle.Default, this.cellID);

			// TODO: populate the cell with the appropriate data based on the indexPath
			cell.TextLabel.Text = this.tableData[rowIndex];

			return cell;
		}

		public override int NumberOfSections (UITableView tableView)
		{
			// TODO: return the actual number of sections
			return 1;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			// TODO: return the actual number of items in the section
			return this.tableData.Count;

		}

		public override string TitleForHeader (UITableView tableView, int section)
		{
			return "Dagens økt:";
		}

		public override string TitleForFooter (UITableView tableView, int section)
		{
			foreach (int item in removedItems) 
			{

			}
			return "Fullførte:";
		}


		public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editStyle, NSIndexPath indexPath)
		{
			if (editStyle == UITableViewCellEditingStyle.Delete)
			{
				this.tableData.RemoveAt (indexPath.Row);
				removedItems.Add (indexPath.Row);

				tableView.DeleteRows (new NSIndexPath[] {
					indexPath
				} , UITableViewRowAnimation.Automatic);
				/* 					{  							} */

			}
		}

		#endregion

		public readonly string cellID;
		//public Dictionary<int, String> tableData;
		public List<string> tableData { get; private set;} 


		public TableSource () // : UITableViewSource
		{
			this.cellID = "cellIdentifier";
			//this.tableData = new Dictionary<int, String> ()
			//0, "Music"
			this.tableData = new List<string> ();
			tableData.Add ("Knebøy");
			tableData.Add ("Pushups");
			tableData.Add ("Situps");
		}}



	public partial class SuperState01ViewController : UIViewController
	{
		public SuperState01ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			this.tblView.Source = new TableSource ();
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

