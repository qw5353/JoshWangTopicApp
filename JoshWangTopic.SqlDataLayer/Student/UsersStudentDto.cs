using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshWangTopic.SqlDataLayer
{
	public class UsersStudentDto
	{
		[Browsable(false)]
        public int Id { get; set; }
        public int Number { get; set; }
		[Browsable(false)]
		public string Password { get; set; }
        public string Name { get; set; }

		public int Score { get; set; }

		public UsersStudentDto() { }
		public UsersStudentDto(int number, string name,  int score = 0)
		{
			this.Name = name;
			this.Score = score;
			this.Number = number;
		}
	}


}
