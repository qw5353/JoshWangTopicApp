namespace JoshWangTopicApp
{
	partial class FormStudentMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentMain));
			this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
			this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.labCount = new System.Windows.Forms.Label();
			this.labWelcome = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewStudent
			// 
			this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.StudentName,
            this.Column1});
			this.dataGridViewStudent.Location = new System.Drawing.Point(29, 166);
			this.dataGridViewStudent.Margin = new System.Windows.Forms.Padding(6);
			this.dataGridViewStudent.Name = "dataGridViewStudent";
			this.dataGridViewStudent.RowTemplate.Height = 24;
			this.dataGridViewStudent.Size = new System.Drawing.Size(412, 434);
			this.dataGridViewStudent.TabIndex = 0;
			this.dataGridViewStudent.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewStudent_CellFormatting);
			// 
			// Number
			// 
			this.Number.DataPropertyName = "Number";
			this.Number.HeaderText = "學號";
			this.Number.Name = "Number";
			this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Number.Width = 70;
			// 
			// StudentName
			// 
			this.StudentName.DataPropertyName = "Name";
			this.StudentName.HeaderText = "名字";
			this.StudentName.Name = "StudentName";
			this.StudentName.Width = 200;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Score";
			this.Column1.HeaderText = "PR值";
			this.Column1.Name = "Column1";
			// 
			// btnAdd
			// 
			this.btnAdd.BackgroundImage = global::JoshWangTopicApp.Properties.Resources._3;
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAdd.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.Salmon;
			this.btnAdd.Location = new System.Drawing.Point(343, 26);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(98, 46);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "ADD";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.BackgroundImage = global::JoshWangTopicApp.Properties.Resources._3;
			this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEdit.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.ForeColor = System.Drawing.Color.Salmon;
			this.btnEdit.Location = new System.Drawing.Point(343, 84);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(6);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(98, 46);
			this.btnEdit.TabIndex = 2;
			this.btnEdit.Text = "EDIT";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.BurlyWood;
			this.label2.Location = new System.Drawing.Point(64, 626);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "結業倒數:";
			// 
			// labCount
			// 
			this.labCount.AutoSize = true;
			this.labCount.BackColor = System.Drawing.Color.Transparent;
			this.labCount.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCount.ForeColor = System.Drawing.Color.BurlyWood;
			this.labCount.Location = new System.Drawing.Point(167, 621);
			this.labCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labCount.Name = "labCount";
			this.labCount.Size = new System.Drawing.Size(0, 32);
			this.labCount.TabIndex = 4;
			// 
			// labWelcome
			// 
			this.labWelcome.AutoSize = true;
			this.labWelcome.BackColor = System.Drawing.Color.Transparent;
			this.labWelcome.ForeColor = System.Drawing.Color.Peru;
			this.labWelcome.Location = new System.Drawing.Point(25, 26);
			this.labWelcome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labWelcome.Name = "labWelcome";
			this.labWelcome.Size = new System.Drawing.Size(100, 24);
			this.labWelcome.TabIndex = 5;
			this.labWelcome.Text = "(歡迎標語)";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Tomato;
			this.label1.Location = new System.Drawing.Point(56, 65);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(254, 69);
			this.label1.TabIndex = 6;
			this.label1.Text = "PRrank";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// FormStudentMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::JoshWangTopicApp.Properties.Resources._3;
			this.ClientSize = new System.Drawing.Size(480, 685);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labWelcome);
			this.Controls.Add(this.labCount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dataGridViewStudent);
			this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MaximumSize = new System.Drawing.Size(496, 724);
			this.MinimumSize = new System.Drawing.Size(496, 724);
			this.Name = "FormStudentMain";
			this.Text = "學生系統";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStudentMain_FormClosing);
			this.Load += new System.EventHandler(this.FormStudentMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewStudent;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labCount;
		private System.Windows.Forms.Label labWelcome;
		private System.Windows.Forms.DataGridViewTextBoxColumn Number;
		private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.Label label1;
	}
}