using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshWangTopic.SqlDataLayer.Teacher
{
	public class UsersTeacherRepostitory
	{
		public UsersTeacherDto Get(string account)
		{
			Func<SqlConnection> funcConn = SqlDb.GetConnection;

			var sql = $"SELECT * FROM UsersTeacher WHERE Account = '{account}'";


			Func<SqlDataReader, UsersTeacherDto> funcAssembler = reader =>
			{

				return new UsersTeacherDto
				{
					Id = reader.GetInt32("Id", 0),
					Name = reader.GetString("Name"),
					Account = reader.GetString("Account")
				};

			};
			return SqlDb.Get(funcConn, funcAssembler, sql);
		}

		public UsersTeacherDto GetByAccount(string number)
		{
			string sql = "SELECT * FROM UsersTeacher WHERE Account = @Account";

			SqlParameter parameter = new SqlParameter("@Account", System.Data.SqlDbType.NVarChar, 50) { Value = number };

			Func<SqlDataReader, UsersTeacherDto> funcAssembler = reader =>
			{
				int id = reader.GetInt32("Id", 0);
				string account = reader.GetString("Account");
				string password = reader.GetString("Password");
				string name = reader.GetString("Name");

				return new UsersTeacherDto() { Id = id, Account = account, Password = password, Name = name };
			};
			return SqlDb.Get(SqlDb.GetConnection, funcAssembler, sql, parameter);
		}

	}
}
