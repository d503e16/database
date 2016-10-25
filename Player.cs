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
		private string _username;
		private int _matches;
		private int _wins;
		private int _points;

		public string Username
		{
			get { return _username; }
			set { _username = value; }
		}	

		public int Matches
		{
			get { return _matches; }
			set { _matches = value; }
		}

		public int Wins
		{
			get { return _wins; }
			set { _wins = value; }
		}

		public int Points
		{
			get { return _points; }
			set { _points = value; }
		}

		public Player (string username, int matches, int wins, int points)
		{
			_username = username;
			_matches = matches;
			_wins = wins;
			_points = points;
		}
	}
}

