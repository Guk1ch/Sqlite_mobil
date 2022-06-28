using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
	public interface ISQLite
	{
		string GetDatabasePath(string filename);
	}
}
