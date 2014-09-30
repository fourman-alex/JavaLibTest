using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Gmailsender; //<----- The reference library

namespace JavaLibTest
{
	[Activity (Label = "JavaLibTest", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);

			var gmailSender = GMailSender.SendMail ("asdf", "sdfad", "sdfasd", "sdfa", "sdfe", "ieie"); //<-- here is the reflected methods it had for example
		
		};
		}
	}
}


