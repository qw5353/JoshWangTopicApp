namespace JoshWangTopicApp
{
	partial class FormTeacherDelete
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacherDelete));
			this.btnDelete = new System.Windows.Forms.Button();
			this.labNumber = new System.Windows.Forms.Label();
			this.txtNumber = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnDelete
			// 
			this.btnDelete.BackgroundImage = global::JoshWangTopicApp.Properties.Resources._6;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.SlateBlue;
			this.btnDelete.Location = new System.Drawing.Point(108, 157);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(217, 77);
			this.btnDelete.TabIndex = 0;
			this.btnDelete.Text = "QUIT TRAINING";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// labNumber
			// 
			this.labNumber.AutoSize = true;
			this.labNumber.BackColor = System.Drawing.Color.Transparent;
			this.labNumber.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labNumber.ForeColor = System.Drawing.Color.SlateBlue;
			this.labNumber.Location = new System.Drawing.Point(147, 40);
			this.labNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labNumber.Name = "labNumber";
			this.labNumber.Size = new System.Drawing.Size(136, 33);
			this.labNumber.TabIndex = 1;
			this.labNumber.Text = "Number";
			// 
			// txtNumber
			// 
			this.txtNumber.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumber.ForeColor = System.Drawing.Color.DodgerBlue;
			this.txtNumber.Location = new System.Drawing.Point(113, 98);
			this.txtNumber.Margin = new System.Windows.Forms.Padding(6);
			this.txtNumber.Multiline = true;
			this.txtNumber.Name = "txtNumber";
			this.txtNumber.Size = new System.Drawing.Size(212, 37);
			this.txtNumber.TabIndex = 2;
			// 
			// FormTeacherDelete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::JoshWangTopicApp.Properties.Resources._6;
			this.ClientSize = new System.Drawing.Size(437, 277);
			this.Controls.Add(this.txtNumber);
			this.Controls.Add(this.labNumber);
			this.Controls.Add(this.btnDelete);
			this.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MaximumSize = new System.Drawing.Size(453, 316);
			this.MinimumSize = new System.Drawing.Size(453, 316);
			this.Name = "FormTeacherDelete";
			this.Text = "退訓來這";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label labNumber;
		private System.Windows.Forms.TextBox txtNumber;
	}
}