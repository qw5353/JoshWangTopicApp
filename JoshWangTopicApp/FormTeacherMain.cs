using JoshWangTopic.SqlDataLayer;
using JoshWangTopic.SqlDataLayer.Assessment;
using JoshWangTopic.SqlDataLayer.Teacher;
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
	public partial class FormTeacherMain : Form ,IGrid
	{
		private string _account;
		public FormTeacherMain(string account)
		{
			InitializeComponent();
			_account = account;
		}

		private void FormTeacherMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}

		private void FormTeacherMain_Load(object sender, EventArgs e)
		{
			Display();

			var user = new UsersTeacherRepostitory().Get(_account);
			labWelcome2.Text = $"歡迎{user.Name}老師登入";
		}
		public void Display()
		{
			AssessmentReposition service = new AssessmentReposition();

			//List<CategoryDto> data = service.Search(name, id);
			var vm = service.Search().ToList();


			dataGridViewStudent.DataSource = vm;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var frm = new FormTeacherDelete();
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void dataGridViewStudent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (this.dataGridViewStudent.Columns[e.ColumnIndex].Name == "Column1"  )
			{
				int score = Convert.ToInt32(e.Value);

				if (score > 80) {e.CellStyle.ForeColor = Color.DarkRed; } 
				else if (score > 60 ) { e.CellStyle.ForeColor = Color.SandyBrown; }
				else e.CellStyle.ForeColor = Color.LightGreen; 
			}
			else if (this.dataGridViewStudent.Columns[e.ColumnIndex].Name == "Column2" ||
				this.dataGridViewStudent.Columns[e.ColumnIndex].Name == "Column3" ||
				this.dataGridViewStudent.Columns[e.ColumnIndex].Name == "Column4" ||
				this.dataGridViewStudent.Columns[e.ColumnIndex].Name == "Column5" ||
				this.dataGridViewStudent.Columns[e.ColumnIndex].Name == "Column6" ||
				this.dataGridViewStudent.Columns[e.ColumnIndex].Name == "Column7")
			{
				int score = Convert.ToInt32(e.Value);

				if (score > 3) { e.CellStyle.ForeColor = Color.DarkRed; }
				else if (score == 3) { e.CellStyle.ForeColor = Color.SandyBrown; }
				else e.CellStyle.ForeColor = Color.LightGreen;
			}
		}
	}
}
