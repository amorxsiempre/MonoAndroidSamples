
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
	[Activity (Label = "ActivityGingerbread")]			
	public class ActivityGingerbread : DashboardActivity 
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource .Layout .activity_gingerbread);
			SetHeader (GetString(Resource.String .GingerbreadActivityTitle) ,true,true);
		}
	}
}

