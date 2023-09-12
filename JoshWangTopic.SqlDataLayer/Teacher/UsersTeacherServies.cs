using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshWangTopic.SqlDataLayer.Teacher
{
	public class UsersTeacherServies
	{
		public bool IsValid(string account, string password)
		{
			//precondition checks
			//account ,password 必填
			if (string.IsNullOrEmpty(account)) { throw new ArgumentException(account, "請入座號"); }
			if (string.IsNullOrEmpty(password)) { throw new ArgumentException(password, "請入密碼"); }

			

			//取得單一使用者
			var obj = new UsersTeacherRepostitory();
			UsersTeacherDto user = obj.GetByAccount(account);
			if (user == null) { return false; }

			//判斷密碼是否正確
			string passwordInDb = user.Password;

			//如果不拘大小寫
			return (passwordInDb.ToLower() == password.ToLower());

			//如果要區分大小寫
			//return passwordInDb == password;
		} 
	}
}
