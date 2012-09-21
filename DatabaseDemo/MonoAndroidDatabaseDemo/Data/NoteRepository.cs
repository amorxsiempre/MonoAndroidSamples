using System;
using System.Collections.Generic;
using Android.Content;
using Android.Database;
using DatabaseDemo .Models;

namespace DatabaseDemo.Data
{
	public class NoteRepository : INoteRepository
	{
		
		private NoteDatabaseHelper _helper;
		
		public NoteRepository(Context context)
		{
			_helper = new NoteDatabaseHelper(context);
		}
		
		public IList<Note> GetAllNotes()
		{
			var notes = new List<Note>();
			var db = _helper.ReadableDatabase;

			ICursor noteCursor;

		    noteCursor = db.Query("Note", null, null, null, null, null, null);

			//Otra forma
			//noteCursor=db.RawQuery ("SELECT Title,Contents FROM Note ",null);

			notes = new List<Note>();
			
			while (noteCursor.MoveToNext())
			{
				notes.Add(mapNote(noteCursor));
			}
			
			return notes;
		}
		
		public void AddNote(string title, string contents)
		{
			var values = new ContentValues();
			values.Put("Title", title);
			values.Put("Contents", contents);

			var db= _helper.WritableDatabase;

			db.Insert("Note",null,values);

			//Otra forma es mediante sentencias sql
			//db.ExecSQL(string.Format
			//           ("INSERT INTO Note(Title,Contents) Values('{0}','{1}' )",title,contents));

		}
		
		private Note mapNote(ICursor cursor)
		{
			return new Note
			{
				Id = cursor.GetInt(0),
				Title = cursor.GetString(1),
				Contents = cursor.GetString(2)
			};
		}
	}
}

