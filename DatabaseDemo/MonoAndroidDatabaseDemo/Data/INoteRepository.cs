
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
using DatabaseDemo.Models;

namespace DatabaseDemo.Data
{
	public interface INoteRepository
	{
		IList<Note> GetAllNotes();
		void AddNote(string title, string contents);
	}
}

