
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
	[Activity (Label = "DashboardActivity")]		
	public class DashboardActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
		}


		public void SetHeader(String title, bool btnHomeVisible, bool btnFeedbackVisible)
    	{
		
      		ViewStub stub = (ViewStub) FindViewById(Resource .Id .vsHeader);
      		View inflated = stub.Inflate();

		    TextView txtTitle = (TextView) inflated.FindViewById(Resource.Id.txtHeading );
		    txtTitle.Text=title;

		    Button btnHome = (Button) inflated.FindViewById(Resource .Id.btnHome );
		  
			if(!btnHomeVisible)
				btnHome.Visibility = Android.Views .ViewStates .Invisible ;

			btnHome .Click+= delegate(object sender, EventArgs e) {

				 Intent intent = new Intent(this.ApplicationContext , typeof (HomeActivity ));
	      		 intent.SetFlags (ActivityFlags.ClearTop );
	      		 StartActivity(intent);
			};

		    Button btnFeedback = (Button) inflated.FindViewById( Resource.Id.btnFeedback);
		    if(!btnFeedbackVisible)
		    	btnFeedback.Visibility = Android.Views .ViewStates .Invisible ;

			btnFeedback .Click += delegate(object sender, EventArgs e) {
			     Intent intent = new Intent(this.ApplicationContext , typeof (ActivityFeedback));
	      		 intent.SetFlags (ActivityFlags.ClearTop );
	      		 StartActivity(intent);

			};
    	}

	}
}

