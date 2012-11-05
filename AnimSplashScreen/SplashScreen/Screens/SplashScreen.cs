using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Views .Animations;


namespace SplashScreen
{
	[Activity (Label = "SplashScreen", MainLauncher = true,
	           Theme = "@android:style/Theme.NoTitleBar",NoHistory = true)]
	public class SplashScreen : Activity
	{
	
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Splash);

			MainScreen actMain = new MainScreen ();

			CountDown tik= new CountDown (5000,5000,this,actMain);
			tik.Start ();
			StartAnimation();

		}

		private void StartAnimation ()
		{
			Animation anim=  AnimationUtils.LoadAnimation (this,Resource.Animation .alpha);
			anim .Reset();

			var lnMain = FindViewById<LinearLayout>(Resource.Id.lnMain);
			lnMain.ClearAnimation();
			lnMain.StartAnimation (anim);

			anim= AnimationUtils.LoadAnimation(this,Resource.Animation.translate);
			anim.Reset ();

			var imgSplash= FindViewById<ImageView>(Resource.Id.imgMain);
			imgSplash.ClearAnimation();
			imgSplash.StartAnimation (anim);

		}

	}
}


