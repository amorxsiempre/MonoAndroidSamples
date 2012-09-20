
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

namespace DashBoardExample
{
	[Activity (Label = "HomeActivity", MainLauncher = true)]			
	public class HomeActivity : DashboardActivity 
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout .Main );

			SetHeader (GetString (Resource.String .HomeActivityTitle),false,true);

			Button btnEcleair= FindViewById <Button>(Resource.Id .main_btn_eclair );
			btnEcleair .Click += delegate(object sender, EventArgs e) {
				Intent intent;
				intent = new Intent(this,typeof(ActivityEclair));
	   			StartActivity(intent);
			};

			Button btnFroyo= FindViewById <Button>(Resource.Id.main_btn_froyo );
			btnFroyo .Click += delegate(object sender, EventArgs e) {
				Intent intent;
				intent = new Intent(this,typeof(ActivityFroyo));
	   			StartActivity(intent);
			};


			Button btnGinger= FindViewById <Button>(Resource.Id.main_btn_gingerbread  );
			btnGinger .Click += delegate(object sender, EventArgs e) {
				Intent intent;
				intent = new Intent(this,typeof(ActivityGingerbread));
	   			StartActivity(intent);
			};

			Button btnICS= FindViewById <Button>(Resource.Id.main_btn_ics  );
			btnICS .Click += delegate(object sender, EventArgs e) {
				Intent intent;
				intent = new Intent(this,typeof(ActivityICS));
	   			StartActivity(intent);
			};


			Button btnJeallyBean= FindViewById <Button>(Resource.Id.main_btn_jellybean  );
			btnJeallyBean .Click += delegate(object sender, EventArgs e) {
				Intent intent;
				intent = new Intent(this,typeof(ActivityJeallyBean));
	   			StartActivity(intent);
			};


			Button btnHoneyComb= FindViewById <Button>(Resource.Id.main_btn_honeycomb );
			btnHoneyComb .Click += delegate(object sender, EventArgs e) {
				Intent intent;
				intent = new Intent(this,typeof(ActivityHoneyComb));
	   			StartActivity(intent);
			};
		}


	}
}