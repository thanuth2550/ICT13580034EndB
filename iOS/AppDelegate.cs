using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace ICT13580034EndB.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			var dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			dbPath = System.IO.Path.Combine(dbPath, "myshop.db3");

			LoadApplication(new App(dbPath));

			return base.FinishedLaunching(app, options);
		}
    }
}
