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
	public partial class FormTeacherDelete : Form
	{
		public FormTeacherDelete()
		{
			InitializeComponent();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int? number = int.TryParse( txtNumber.Text ,out int num) ? num : (int?)null;

			if ( !number.HasValue || number<1 || number>39)
			{
				MessageBox.Show("請輸入正確學生學號 , 請再試一次");
				return;
			}
			

			DialogResult result = MessageBox.Show($"座號{num}號同學將被退訓", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				int student = new AssessmentReposition().Delete(num);

				if (student == 1)
				{
					MessageBox.Show($"{num}號 同學跟您說再見~");
					FormTeacherDelete form = Application.OpenForms.OfType<FormTeacherDelete>().FirstOrDefault();
					form?.Close();

				}
				else
				{
					MessageBox.Show("沒有此學生存在，紀錄可能已被清除");
				}
			}

			IGrid owner = (IGrid)this.Owner;
			owner.Display();
			return;
		}
	}
}
