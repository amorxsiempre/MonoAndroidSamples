
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
	[Activity (Label = "ActivityEclair")]			
	public class ActivityEclair : DashboardActivity 
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout .activity_eclair );
			SetHeader (GetString(Resource.String .EclairActivityTitle ) ,true,true);
			// Create your application here
		}
	}
}

