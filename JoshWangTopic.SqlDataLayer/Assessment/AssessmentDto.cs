using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshWangTopic.SqlDataLayer.Assessment
{
	public class AssessmentDto
	{
		[Browsable(false)]
		public int Id { get; set; }
        public string Name { get; set; }
        public int Course { get; set; }
        public int Teaching { get; set; }
        public int Pressure { get; set; }
        public int Commute { get; set; }
        public int Absent { get; set; }
        public int Classmate { get; set; }
        public int UserStudentNumber { get; set; }
        public int PRValue { get; set; }

        public AssessmentDto() { }
        public AssessmentDto(int number, string name, int prValue, int course, int teaching, int pressure, int commute, int acsent, int classmate) 
        {
			UserStudentNumber = number;
            Name = name;
            Course = course;
            Teaching = teaching;
            Pressure = pressure;
            Commute = commute;
            Absent = acsent;
            Classmate = classmate;
            PRValue = prValue;

        }
    }
}
