
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
using DatabaseDemo.Data;
namespace DatabaseDemo
{
	[Application]
	public class DemoApp : Application
	{

		public INoteRepository NoteRepository { get; set; }
		
		public DemoApp(IntPtr handle, JniHandleOwnership transfer)
			: base(handle, transfer)
		{
		}
		
		public override void OnCreate()
		{
			base.OnCreate();
			NoteRepository = new NoteRepository (this);


		}

	}
}

