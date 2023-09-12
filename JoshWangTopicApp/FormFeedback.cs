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
	public partial class FormFeedback : Form
	{
		private int _Num { get; set; }
		public FormFeedback(int num)
		{
			InitializeComponent();
			_Num = num;	
		}

		private void FormFeedback_FormClosing(object sender, FormClosingEventArgs e)
		{
			//var frm = new FormAssessment(_Num);
			//frm.Close();

			FormAssessment form1 = Application.OpenForms.OfType<FormAssessment>().FirstOrDefault();
			form1?.Close();
		}

		private void FormFeedback_Load(object sender, EventArgs e)
		{
			var user = new AssessmentReposition().Get(_Num); ;
			labPRNumber.Text = user.PRValue.ToString();
			UpdateForm(user.PRValue);
		}

		public void UpdateForm(int pr)
		{
			if (pr < 60)
			{
				labTitle.Text = "讚讚，繼續保持!";
				BackColor = Color.LightGreen;
			}
			else if (pr > 60 && pr < 80)
			{
				labTitle.Text = "可再改善!";
				BackColor = Color.Khaki;
			}
			else
			{
				labTitle.Text = "退訓離你不遠了";
				BackColor = Color.Tomato;
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
