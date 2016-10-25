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
		/*private Database _data;
		private List<string> _info;
		private List<Player> _allPlayers;*/


		public Database Data
		{
			get { return _data; }
			set { _data = value; }
		}

		public static void Main (string[] args)
		{
			Database data = new Database ();
			data.InitDatabase ();
			/*_info = new List<string>();
			_allPlayers = new List<Player>();*/
		}


		/*public void LoadPlayersFromDatabase()
		{
			string sql = "SELECT * FROM userTable";
			_data.Read(sql, ref _info, _data.playerTableColumns);
			foreach (var item in _info)
			{
				string[] split = item.Split(new Char[] { ',' });
				_allPlayers.Add(new Player(split[0], int.Parse(split[1]),int.Parse(split[2]), int.Parse(split[3])));
			}
			foreach (Player item in _allPlayers)  
			{
				Console.WriteLine (item.Username + item.Points);
			}
		}*/

	}
}
