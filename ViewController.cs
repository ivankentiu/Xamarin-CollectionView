using System;
using System.Collections.Generic;
using UIKit;

namespace collectionviewapp
{
    public partial class ViewController : UIViewController
    {
        List<string> collectionItems;

        protected ViewController(IntPtr handle) : base(handle) {
            collectionItems = new List<string>();
            var alphabet = new string[] { "a", "b", "c", "d", "e" };
            var random = new Random();
            for (var i = 0; i < 100; i++) {
                collectionItems.Add(alphabet[random.Next(0, 4)]);
            }
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            collectionView.RegisterClassForCell(typeof(CustomCollectionViewCell), CustomCollectionViewCell.CellID);
            collectionView.Source = new CustomCollectionSource(collectionItems);

            collectionView.ReloadData();
        }

        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
