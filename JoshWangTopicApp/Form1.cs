using JoshWangTopic.SqlDataLayer;
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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = 0;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex == 0)
			{
				UsersStudentServies service = new UsersStudentServies();
				try
				{
					(bool item,int num) validationResult = service.IsValid(txtAccount.Text, txtPassword.Text);
					//if (validationResult == false)
					if (validationResult.item == false)
					{
						MessageBox.Show("帳號密碼有誤，請在試一次");
						return;
					}
					else if(int.Parse(txtAccount.Text) == 6) 
					{
						MessageBox.Show($"6號 林于翔同學直接退訓", "沒救了", MessageBoxButtons.OK, MessageBoxIcon.Stop);
						return;
					}

					//清空表單值，以便下次再顯示時，不會有值
					txtAccount.Text = string.Empty;
					txtPassword.Text = string.Empty;

					var frm = new FormStudentMain(validationResult.num);
					frm.Owner = this;

					//這點很重要，不能將FormLogin關閉，只能隱藏
					//否則目前的 application就會視同結束
					this.Hide();

					//稍後FormMain關閉時，再將FornLogin顯示
					frm.ShowDialog();

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					return;
				}

			}

			else
			{
				UsersTeacherServies service2 = new UsersTeacherServies();
				try
				{
					bool validationResult = service2.IsValid(txtAccount.Text, txtPassword.Text);
					if (validationResult == false)
					{
						MessageBox.Show("帳號密碼有誤，請在試一次");
						return;
					}

					var frm = new FormTeacherMain(txtAccount.Text);
					frm.Owner = this;

					//清空表單值，以便下次再顯示時，不會有值
					txtAccount.Text = string.Empty;
					txtPassword.Text = string.Empty;

					//這點很重要，不能將FormLogin關閉，只能隱藏
					//否則目前的 application就會視同結束
					this.Hide();

					//稍後FormMain關閉時，再將FornLogin顯示
					frm.ShowDialog();

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					return;
				}
			}
		}
	}
}
