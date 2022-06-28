using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TestApp
{ [Table ("TaskTimetable")]
	public class TaskTimetable
	{
		[PrimaryKey, AutoIncrement, Column("_id")]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Discription { get; set; }
		public DateTime Time { get; set; }
	}
}
