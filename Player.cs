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
	public class Player
	{

		public int Id { get; set; }
		public string Username { get; set; }
		public int Rank { get; set; }


		public Player (int id, string username, int rank)
		{
			
		}
	}
}

