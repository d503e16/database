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
		private int _id;
		private string _username;
		private int _points;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
			
		public string Username
		{
			get { return _username; }
			set { _username = value; }
		}	

		public int Points
		{
			get { return _points; }
			set { _points = value; }
		}

		public Player (int id, string username, int points)
		{
			_id = id;
			_username = username;
			_points = points;
		}
	}
}

