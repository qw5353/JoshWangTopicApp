using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace JoshWangTopic.SqlDataLayer
{
	public class UsersStudentRepostitory
	{
		public UsersStudentDto Get(int number)
		{
			Func<SqlConnection> funcConn = SqlDb.GetConnection;

			var sql = $"SELECT * FROM UsersStudent WHERE Number = {number}";


			Func<SqlDataReader, UsersStudentDto> funcAssembler = reader =>
			{

				return new UsersStudentDto
				{
					Name = reader.GetString("Name")
				};

			};
			return SqlDb.Get(funcConn, funcAssembler, sql);
		}

		public UsersStudentDto GetByAccount(int number)
		{
			string sql = "SELECT * FROM UsersStudent WHERE Number = @Number";

			SqlParameter parameter = new SqlParameter("@Number", System.Data.SqlDbType.NVarChar, 50) { Value = number };

			Func<SqlDataReader, UsersStudentDto> funcAssembler = reader =>
			{
				int id = reader.GetInt32("Id", 0);
				int num = reader.GetInt32("Number",0);
				string password = reader.GetString("Password");
				string name = reader.GetString("Name");

				return new UsersStudentDto() { Id = id, Number = num, Password = password ,Name = name};
			};
			return SqlDb.Get(SqlDb.GetConnection, funcAssembler, sql, parameter);
		}

		public List<UsersStudentDto> Search()
		{
			List<SqlParameter> parameters = new List<SqlParameter>();

			string sql = @"SELECT UserStudentNumber ,u.Name,
    CAST((PERCENT_RANK() OVER (ORDER BY TotalSum) * 98 + 1) AS INT) AS [PRValue]
FROM (
    SELECT UserStudentNumber, SUM(Course + Teaching + Pressure + Commute + Absent + Classmate) AS TotalSum
    FROM Assessment
    GROUP BY UserStudentNumber
) AS Subquery
join UsersStudent u on  u.Number =Subquery.UserStudentNumber 
ORDER BY [PRValue] DESC;";


			//sql += " ORDER BY DisplayOrder";

			Func<SqlDataReader, UsersStudentDto> funcAssembler = reader =>
			{
				int number = reader.GetInt32("UserStudentNumber", 0);
				string name = reader.GetString("Name");
				int score = reader.GetInt32("PRValue", 0);

				return new UsersStudentDto(number, name, score);
			};
			return SqlDb.Search(SqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());
		}

	}
}
