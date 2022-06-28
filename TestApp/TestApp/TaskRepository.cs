using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TestApp
{
	public class TaskRepository
	{
		SQLiteConnection database;
		public TaskRepository(string databasePath)
		{
			database = new SQLiteConnection(databasePath);
			database.CreateTable<TaskTimetable>();
		}
		public IEnumerable<TaskTimetable> GetItems()
		{
			return database.Table<TaskTimetable>().ToList();
		}
		public TaskTimetable GetTask(int id) 
		{
			return database.Get<TaskTimetable>(id);
		}
		public int DeleteItem(int id)
		{
			return database.Delete<TaskTimetable>(id);
		}
		public int SaveItem(TaskTimetable item)
		{
			if (item.Id != 0)
			{
				database.Update(item);
				return item.Id;
			}
			else
			{
				return database.Insert(item);
			}
		}
	}
}
