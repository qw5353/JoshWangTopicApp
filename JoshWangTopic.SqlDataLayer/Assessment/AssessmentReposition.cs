using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshWangTopic.SqlDataLayer.Assessment
{
	public class AssessmentReposition
	{
		public int Create(AssessmentDto dto)
		{
			//取得剛新增資料的自動編號
			string sql = @"
INSERT Assessment
(UserStudentNumber, Course,Teaching,Pressure,Commute, Absent, Classmate)
VALUES
(@UserStudentNumber, @Course,@Teaching,@Pressure,@Commute,@Absent,@Classmate);";


			var parameters = SqlParameterBuilder.Create()
				.AddInt("@UserStudentNumber", dto.UserStudentNumber)
				.AddInt("@Course", dto.Course)
				.AddInt("@Teaching", dto.Teaching)
				.AddInt("@Pressure", dto.Pressure)
				.AddInt("@Commute", dto.Commute)
				.AddInt("@Absent", dto.Absent)
				.AddInt("@Classmate", dto.Classmate)
				.Build();

			return SqlDb.Create(SqlDb.GetConnection,
										sql,
										parameters);

		}

		public AssessmentDto Get(int number)
		{

			Func<SqlConnection> funcConn = SqlDb.GetConnection;

			var sql = @"SELECT * FROM (
SELECT UserStudentNumber , 
    CAST((PERCENT_RANK() OVER (ORDER BY TotalSum ) * 98 + 1) AS INT) AS [PRValue]
FROM (
    SELECT UserStudentNumber, SUM(Course + Teaching + Pressure + Commute + Absent + Classmate) AS TotalSum
    FROM Assessment
    GROUP BY UserStudentNumber
) AS Subquery
) as T
WHERE T.UserStudentNumber = "+number+";";


			Func<SqlDataReader, AssessmentDto> funcAssembler = reader =>
			{

				return new AssessmentDto
				{
					UserStudentNumber = reader.GetInt32("UserStudentNumber", 0),
					PRValue = reader.GetInt32("PRValue", 0)
				};

			};
			return SqlDb.Get(funcConn, funcAssembler, sql);

		}

		public int update(AssessmentDto dto)
		{
			string sql = @"
UPDATE Assessment SET
Course =@Course,
Teaching =@Teaching,
Pressure = @Pressure,
Commute = @Commute,
Absent = @Absent,
Classmate = @Classmate
WHERE
UserStudentNumber = @UserStudentNumber";

			SqlParameter[] parameters = SqlParameterBuilder.Create()
				.AddInt("@Course",  dto.Course)
				.AddInt("@Teaching",  dto.Teaching)
				.AddInt("@Pressure",  dto.Pressure)
				.AddInt("@Commute", dto.Commute)
				.AddInt("@Absent", dto.Absent)
				.AddInt("@Classmate",  dto.Classmate)
				.AddInt("@UserStudentNumber", dto.UserStudentNumber)
				.Build();

			return SqlDb.UpdateOrDelete(SqlDb.GetConnection,
										sql,
										parameters);

		}

		public int Delete(int account)
		{
			string sql = @"
DELETE FROM Assessment 
WHERE
UserStudentNumber = @UserStudentNumber";

			SqlParameter[] parameters = SqlParameterBuilder.Create()
			.AddInt("@UserStudentNumber",  account)
			.Build();

			return SqlDb.UpdateOrDelete(SqlDb.GetConnection,
										sql,
										parameters);
		}

		public AssessmentDto GetValue(int number)
		{

			Func<SqlConnection> funcConn = SqlDb.GetConnection;

			var sql = $"select * from Assessment where UserStudentNumber = {number} ";


			Func<SqlDataReader, AssessmentDto> funcAssembler = reader =>
			{

				return new AssessmentDto
				{
					Course = reader.GetInt32("Course", 0),
					Teaching = reader.GetInt32("Teaching", 0),
					Pressure = reader.GetInt32("Pressure", 0),
					Commute = reader.GetInt32("Commute", 0),
					Absent = reader.GetInt32("Absent", 0),
					Classmate = reader.GetInt32("Classmate", 0),
					UserStudentNumber = reader.GetInt32("UserStudentNumber", 0)
				};

			};
			return SqlDb.Get(funcConn, funcAssembler, sql);

		}

		public List<AssessmentDto> Search()
		{
			List<SqlParameter> parameters = new List<SqlParameter>();

			string sql = @"SELECT MainQuery.UserStudentNumber, MainQuery.Name, MainQuery.[PRValue], Assessment.Course, Assessment.Teaching, Assessment.Pressure, Assessment.Commute, Assessment.Absent, Assessment.Classmate
FROM (
    SELECT Subquery.UserStudentNumber, Subquery.Name, Subquery.[PRValue], ROW_NUMBER() OVER (ORDER BY Subquery.[PRValue] DESC) AS RowNumber
    FROM (
        SELECT UserStudentNumber, Name, CAST((PERCENT_RANK() OVER (ORDER BY TotalSum ) * 98 + 1) AS INT) AS [PRValue]
        FROM (
            SELECT UserStudentNumber, SUM(Course + Teaching + Pressure + Commute + Absent + Classmate) AS TotalSum
            FROM Assessment
            GROUP BY UserStudentNumber
        ) AS Subquery 
        JOIN UsersStudent ON UsersStudent.Number = Subquery.UserStudentNumber
    ) AS Subquery
) AS MainQuery
JOIN Assessment ON Assessment.UserStudentNumber = MainQuery.UserStudentNumber
WHERE MainQuery.RowNumber <= 100
ORDER BY MainQuery.[PRValue] DESC;";


			//sql += " ORDER BY DisplayOrder";

			Func<SqlDataReader, AssessmentDto> funcAssembler = reader =>
			{
				int number = reader.GetInt32("UserStudentNumber", 0);
				string name = reader.GetString("Name");
				int prValue = reader.GetInt32("PRValue", 0);
				int course = reader.GetInt32("Course", 0);
				int teaching = reader.GetInt32("Teaching", 0);
				int pressure = reader.GetInt32("Pressure", 0);
				int commute = reader.GetInt32("Commute", 0);
				int absent = reader.GetInt32("Absent", 0);
				int classmate = reader.GetInt32("Classmate", 0);

				return new AssessmentDto(number, name, prValue, course, teaching, pressure, commute, absent, classmate);
			};
			return SqlDb.Search(SqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());
		}

	}
}
