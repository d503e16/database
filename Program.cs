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

		#Her mangler der at identificere matchid, og lægge den ind i databasen
		public AddMatches(string match)
		{
			string sql = "INSERT OR REPLACE INTO matchTable (matchId, match) values ('" + match + "')";
			Data.Execute(sql);
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
