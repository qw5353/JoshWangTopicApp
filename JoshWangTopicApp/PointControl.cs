using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoshWangTopicApp
{
	public partial class PointControl : UserControl
	{
		public PointControl()
		{
			InitializeComponent();
			radioButton1.Checked = true;
		}

		private void radioButtonGroup_CheckedChanged(object sender, EventArgs e)
		{

		}

		public int GetValue()
		{
			return int.Parse(this.Controls.OfType<RadioButton>().Single(ctrl => ctrl.Checked).Name.Replace("radioButton", string.Empty));
		}

		private void PointControl_Load(object sender, EventArgs e)
		{
			
		}

		public void SetCheckedRadioButton(int score)
		{
			var propertyName = $"radioButton{score}";
			var rb = typeof(PointControl).GetField(propertyName, BindingFlags.NonPublic | BindingFlags.Instance);
			object o = rb.GetValue(this);
			RadioButton r = o as RadioButton;
			if (!(r is null))
			{
				r.Checked = true;
			}

			//switch (score)
			//{
			//	case 1:
			//		radioButton1.Checked = true; 
			//		break;
			//	case 2:
			//		radioButton2.Checked = true;
			//		break;
			//	case 3:
			//		radioButton3.Checked = true;
			//		break;
			//	case 4:
			//		radioButton4.Checked = true;
			//		break;
			//	case 5:
			//		radioButton5.Checked = true;
			//		break;
			//	default:
			//		radioButton5.Checked = true;
			//		break;
			//}
		}
	}
}
