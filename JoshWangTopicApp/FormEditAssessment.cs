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
	public partial class FormEditAssessment : Form
	{
		private int _number;
		public FormEditAssessment(int number)
		{
			_number = number;
			InitializeComponent();
		}

		private void FormEditAssessment_Load(object sender, EventArgs e)
		{
			BindDataToPointControls();
		}

		private void BindDataToPointControls()
		{
			var repo = new AssessmentReposition();
			var assessment = repo.GetValue(_number);

			pointControlAbsent.SetCheckedRadioButton(assessment.Absent);
			pointControlCourse.SetCheckedRadioButton(assessment.Course);
			pointControlTeaching.SetCheckedRadioButton(assessment.Teaching);
			pointControlPressure.SetCheckedRadioButton(assessment.Pressure);
			pointControlCommute.SetCheckedRadioButton(assessment.Commute);
			pointControlClassmate.SetCheckedRadioButton(assessment.Classmate);
		}

		private void btnEdit_Click(object sender, EventArgs e)
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
				UserStudentNumber = _number
			};

			var user = new AssessmentReposition();
			user.update(dto);

			var frm = new FormFeedback(_number);
			frm.Owner = this;
			frm.ShowDialog();

			IGrid owner = (IGrid)this.Owner;
			owner.Display();

			Close();



			//FormStudentMain_Load(this, EventArgs.Empty);
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}
	}
}
