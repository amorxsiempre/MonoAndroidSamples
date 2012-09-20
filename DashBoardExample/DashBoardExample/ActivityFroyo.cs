
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
	[Activity (Label = "ActivityFroyo")]			
	public class ActivityFroyo : DashboardActivity 
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource .Layout .activity_froyo );
			SetHeader(GetString(Resource.String.FroyoActivityTitle) ,true,true);
		}
	}
}

