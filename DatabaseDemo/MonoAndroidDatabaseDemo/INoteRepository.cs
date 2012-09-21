
using System;
using System.Collections.Generic;
using MonoAndroidDatabaseDemo.Models;

namespace MonoAndroidDatabaseDemo
{
	interface INoteRepository
	{
		IList<Note> GetAllNotes();
		long AddNote(string title,string content);
	}
}

