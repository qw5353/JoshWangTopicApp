using JoshWangTopic.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JoshWangTopicApp
{
	public partial class FormStudentMain : Form , IGrid
	{
        private int _Number { get; set; }
		private int _remainingSeconds;  // 剩餘天數
		private DateTime _endDate;   // 截止日期
		private Timer _countdownTimer;
		public FormStudentMain(int num)
		{
			InitializeComponent();
			_Number = num;
		}

		private void FormStudentMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}

		public void Display()
		{
			UsersStudentRepostitory service = new UsersStudentRepostitory();

			//List<CategoryDto> data = service.Search(name, id);
			var vm = service.Search().ToList();
			if (vm.Exists(v => v.Number == _Number))
				btnAdd.Visible = false;

			
			dataGridViewStudent.DataSource = vm;
		}

		private void FormStudentMain_Load(object sender, EventArgs e)
		{
			Display();
			// 設定截止日期為 2023 年 9 月 8 日
			_endDate = new DateTime(2023, 9, 8);
			TimeSpan remainingTime = _endDate - DateTime.Now;
			_remainingSeconds = (int)remainingTime.TotalSeconds;


			// 設定 Timer 控制項的屬性
			_countdownTimer = new Timer();
			_countdownTimer.Interval = 1000;
			_countdownTimer.Tick += CountdownTimer_Tick;  // 設定計時器的事件處理程序
			_countdownTimer.Start();  // 啟動計時器

			var user = new UsersStudentRepostitory().Get(_Number);
			labWelcome.Text = $"歡迎{user.Name}同學登入";


		}

		private void CountdownTimer_Tick(object sender, EventArgs e)
		{
			_remainingSeconds--;

			// 計算剩餘時間
			TimeSpan remainingTime = _endDate - DateTime.Now;
			string countText = $"{remainingTime.Days}Days  {remainingTime.Hours.ToString().PadLeft(2, '0')}:{remainingTime.Minutes.ToString().PadLeft(2, '0')}:{remainingTime.Seconds.ToString().PadLeft(2, '0')}";


			// 更新倒數時間顯示
			

			// 檢查是否到達截止日期
			if (_remainingSeconds <= 0)
			{
				labCount.Text = "結訓時間已到";
				((Timer)sender).Stop();  // 停止計時器
			}
			else
			{
				labCount.Text = countText;
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			//foreach (DataGridViewRow row in dataGridViewStudent.Rows)
			//{
			//	if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == _Number.ToString())
			//	{
			//		MessageBox.Show("不能重複新增評量。");
			//		break;
			//	}
			//	break;
			//}		
			//
			var frm = new FormAssessment(_Number);
			frm.Owner = this;
			frm.ShowDialog();

		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			var frm = new FormEditAssessment(_Number);
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void dataGridViewStudent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (this.dataGridViewStudent.Columns[e.ColumnIndex].Name == "Column1")
			{
				int score = Convert.ToInt32(e.Value);

				if (score > 80) { e.CellStyle.ForeColor = Color.DarkRed; }
				else if (score > 60) { e.CellStyle.ForeColor = Color.SandyBrown; }
				else e.CellStyle.ForeColor = Color.LightGreen;
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
