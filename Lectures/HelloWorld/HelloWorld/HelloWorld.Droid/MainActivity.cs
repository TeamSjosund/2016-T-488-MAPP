﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace HelloWorld.Droid
{
	[Activity (Label = "HelloWorld.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			this.SetContentView (Resource.Layout.Main);

			// Get our UI controls from the loaded layout
		    var nameEditText = this.FindViewById<EditText>(Resource.Id.nameEditText);

            var greetingTextView = this.FindViewById<TextView>(Resource.Id.greetingTextView);

            var greetingButton = this.FindViewById<Button>(Resource.Id.greetingButton);
            greetingButton.Click += (sender, args) =>
                    { greetingTextView.Text = "Hello " + nameEditText.Text; }; 
        }
    }
}


