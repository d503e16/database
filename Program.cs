using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data.Common;

namespace database
{
	class MainClass
	{
		public List<string> Info { get; set; }

		public Database Data { get; set; }
		public List<string> Matches { get; set; }

		public static void Main (string[] args)
		{
			Data.InitDatabase ();
		}


		public void LoadMatches()
		{
			string sql = "SELECT * FROM matchTable";
			Data.Read (sql, ref Info, Data.matchTableColumns);
			foreach (var item in Info) 
			{
				Matches.Add (item);
			}
		}
	}
}
