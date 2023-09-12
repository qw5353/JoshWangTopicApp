using JoshWangTopic.SqlDataLayer.Assessment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoshWangTopicApp
{
	
	public partial class FormAssessment : Form
	{
		private int _Num { get; set; }
		public FormAssessment(int num)
		{
			InitializeComponent();
			_Num = num;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Dictionary<string, int> scoresMap = new Dictionary<string, int>();
			foreach (PointControl ctrl in this.Controls.OfType<PointControl>()) 
			{
				scoresMap.Add(ctrl.Name.Replace("pointControl", ""), ctrl.GetValue());
			}

			var dto = new AssessmentDto()
			{
				Course = scoresMap["Course"],
				Teaching = scoresMap["Teaching"],
				Pressure = scoresMap["Pressure"],
				Commute = scoresMap["Commute"],
				Absent = scoresMap["Absent"],
				Classmate = scoresMap["Classmate"],
				UserStudentNumber = _Num
			};

			var user = new AssessmentReposition();
			user.Create(dto);

			var frm = new FormFeedback(_Num);
			frm.Owner = this;
			frm.ShowDialog();

			IGrid owner = (IGrid)this.Owner;
			owner.Display();

			//int totalScore = this.Controls.OfType<PointControl>().Aggregate(0, (acc, cur) => acc + cur.GetValue());
			//MessageBox.Show(totalScore.ToString());


		}

		private void FormAssessment_Load(object sender, EventArgs e)
		{

		}
	}
}
