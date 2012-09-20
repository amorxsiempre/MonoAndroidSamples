
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
	[Activity (Label = "ActivityFeedback")]			
	public class ActivityFeedback : DashboardActivity 
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource .Layout .activity_feedback );
			SetHeader (GetString(Resource.String .FeedbackActivityTitle) ,true,true);
		
		}
	}
}

