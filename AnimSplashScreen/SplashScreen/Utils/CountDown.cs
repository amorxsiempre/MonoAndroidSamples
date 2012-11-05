
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

namespace SplashScreen
{
	public class CountDown : CountDownTimer
	{
		private Activity act;
		private Activity actLaunch;

		public CountDown (long millisInFuture, long countDownInterval, Activity act, Activity actLaunch): 
			base (millisInFuture,countDownInterval)
		{
			this.act = act ;
			this.actLaunch= actLaunch;
		}

		public override void OnFinish ()
		{
			act.StartActivity (actLaunch.GetType());
			act.Finish ();
		}

		public override void OnTick (long millisUntilFinished)
		{
			
		}

	}
}

