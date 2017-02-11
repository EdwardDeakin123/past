
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Drawing; 
 
 
namespace Stop_It
{
	[Activity(Label = "StopIt", Icon = "@mipmap/Icon", MainLauncher = true)]
	public class PickList : Activity
	{
		
		Button b1;
		Button b2;
		Button b3; 
		Button b4; 
		Button b5;
		ImageView beer;
		ImageView milk;
		ImageView Alco;
		ImageView FF;
		ImageView Candy; 
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);




			SetContentView(Resource.Layout.ListP2);

			beer = FindViewById< ImageView > (Resource.Id.image1);
			milk = FindViewById<ImageView>(Resource.Id.image2);
			Alco = FindViewById<ImageView>(Resource.Id.image3);
			FF = FindViewById<ImageView>(Resource.Id.image4);
			Candy = FindViewById<ImageView>(Resource.Id.image5);

			b1 = FindViewById<Button>(Resource.Id.bu1);

			b2 = FindViewById<Button>(Resource.Id.bu2);

			b3 = FindViewById<Button>(Resource.Id.bu3);
			b4 = FindViewById<Button>(Resource.Id.bu4);
			b5 = FindViewById<Button>(Resource.Id.bu5);



			if (b1 != null )
			{
				b1.Click += (sender, e) =>
				{
					int numpass = 2;

					var showEvents1 = new Intent(this, typeof(CalendarListActivity));
					showEvents1.PutExtra("numpass1", numpass);
					StartActivity(showEvents1); ;
				};
			}


			if (b2 != null)
			{

				b2.Click += (sender, e) =>
					
				{
					int numpass2 = 3;
					var showEvents2 = new Intent(this, typeof(CalendarListActivity));
					showEvents2.PutExtra("numpass1", numpass2);
					StartActivity(showEvents2);
				};
			}

			if (b3 != null)
			{
				b3.Click += (sender, e) =>
				{
					int numpass3 = 4;
					var showEvents3 = new Intent(this, typeof(CalendarListActivity));
					showEvents3.PutExtra("numpass1", numpass3);
					StartActivity(showEvents3);
				};
			}

			if (b4 != null)
			{
				b4.Click += (sender, e) =>
				{
					int numpass4 = 5;
					var showEvents1 = new Intent(this, typeof(CalendarListActivity));
					showEvents1.PutExtra("numpass1", numpass4);
					StartActivity(showEvents1);
				};
			}

			if (b5 != null)
			{
				b5.Click += (sender, e) =>
				{
					int numpass5 = 6;
					var showEvents4 = new Intent(this, typeof(CalendarListActivity));
					showEvents4.PutExtra("numpass1", numpass5);
					StartActivity(showEvents4);
				};
			}

			//if (b5 != null)
			//{
				//b5.Click += (sender, e) =>
				//{
				//	int numpass6 = 7;
				//	var showEvents5 = new Intent(this, typeof(CalendarListActivity));
				//	showEvents5.PutExtra("numpass1", numpass6);
				//	StartActivity(showEvents5);
				}
			//}
		}
			// Create your application here
		}



