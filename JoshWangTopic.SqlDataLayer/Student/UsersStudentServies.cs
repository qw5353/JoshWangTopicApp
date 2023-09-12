using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshWangTopic.SqlDataLayer
{
	public class UsersStudentServies
	{
		public (bool,int) IsValid(string number, string password)
		{

			
			//precondition checks
			//account ,password 必填
			if (string.IsNullOrEmpty(number)) { throw new ArgumentException(number, "請入座號"); }
			if (string.IsNullOrEmpty(password)) { throw new ArgumentException(password, "請入密碼"); }

			int num = int.Parse(number);

			//取得單一使用者
			var obj = new UsersStudentRepostitory();
			UsersStudentDto user = obj.GetByAccount(num);
			if (user == null) { return (false,0); }

			//判斷密碼是否正確
			string passwordInDb = user.Password;

			//如果不拘大小寫
			return (passwordInDb.ToLower() == password.ToLower(), num);

			//如果要區分大小寫
			//return passwordInDb == password;
		}
	}
}
