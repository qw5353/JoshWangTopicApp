namespace JoshWangTopicApp
{
	partial class FormTeacherMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacherMain));
			this.btnDelete = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.labWelcome2 = new System.Windows.Forms.Label();
			this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
			this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Turquoise;
			this.btnDelete.BackgroundImage = global::JoshWangTopicApp.Properties.Resources.watermark;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnDelete.ForeColor = System.Drawing.Color.Tomato;
			this.btnDelete.Location = new System.Drawing.Point(661, 46);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(150, 46);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "給他退訓";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Tomato;
			this.label1.Location = new System.Drawing.Point(196, 46);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(254, 69);
			this.label1.TabIndex = 4;
			this.label1.Text = "PRrank";
			// 
			// labWelcome2
			// 
			this.labWelcome2.AutoSize = true;
			this.labWelcome2.BackColor = System.Drawing.Color.Transparent;
			this.labWelcome2.ForeColor = System.Drawing.Color.DarkRed;
			this.labWelcome2.Location = new System.Drawing.Point(24, 18);
			this.labWelcome2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labWelcome2.Name = "labWelcome2";
			this.labWelcome2.Size = new System.Drawing.Size(100, 24);
			this.labWelcome2.TabIndex = 6;
			this.labWelcome2.Text = "(歡迎標語)";
			// 
			// dataGridViewStudent
			// 
			this.dataGridViewStudent.AllowUserToAddRows = false;
			this.dataGridViewStudent.AllowUserToDeleteRows = false;
			this.dataGridViewStudent.BackgroundColor = System.Drawing.Color.Ivory;
			this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.TeacherName,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
			this.dataGridViewStudent.GridColor = System.Drawing.Color.SaddleBrown;
			this.dataGridViewStudent.Location = new System.Drawing.Point(28, 128);
			this.dataGridViewStudent.Margin = new System.Windows.Forms.Padding(6);
			this.dataGridViewStudent.Name = "dataGridViewStudent";
			this.dataGridViewStudent.ReadOnly = true;
			this.dataGridViewStudent.RowTemplate.Height = 24;
			this.dataGridViewStudent.Size = new System.Drawing.Size(783, 522);
			this.dataGridViewStudent.TabIndex = 9;
			this.dataGridViewStudent.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewStudent_CellFormatting);
			// 
			// Number
			// 
			this.Number.DataPropertyName = "UserStudentNumber";
			this.Number.HeaderText = "座號";
			this.Number.Name = "Number";
			this.Number.ReadOnly = true;
			this.Number.Width = 60;
			// 
			// TeacherName
			// 
			this.TeacherName.DataPropertyName = "Name";
			this.TeacherName.HeaderText = "名字";
			this.TeacherName.Name = "TeacherName";
			this.TeacherName.ReadOnly = true;
			this.TeacherName.Width = 180;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "PRValue";
			this.Column1.HeaderText = "PR值";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 80;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Course";
			this.Column2.HeaderText = "課程內容";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 70;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Teaching";
			this.Column3.HeaderText = "教學方式";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 70;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Pressure";
			this.Column4.HeaderText = "壓力值";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 70;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Commute";
			this.Column5.HeaderText = "通勤";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 70;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "Absent";
			this.Column6.HeaderText = "出缺席";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 70;
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "Classmate";
			this.Column7.HeaderText = "同學關係";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 70;
			// 
			// FormTeacherMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.BackgroundImage = global::JoshWangTopicApp.Properties.Resources._1;
			this.ClientSize = new System.Drawing.Size(847, 690);
			this.Controls.Add(this.dataGridViewStudent);
			this.Controls.Add(this.labWelcome2);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MaximumSize = new System.Drawing.Size(863, 729);
			this.MinimumSize = new System.Drawing.Size(863, 729);
			this.Name = "FormTeacherMain";
			this.Text = "教師系統";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTeacherMain_FormClosing);
			this.Load += new System.EventHandler(this.FormTeacherMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labWelcome2;
		private System.Windows.Forms.DataGridView dataGridViewStudent;
		private System.Windows.Forms.DataGridViewTextBoxColumn Number;
		private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
	}
}