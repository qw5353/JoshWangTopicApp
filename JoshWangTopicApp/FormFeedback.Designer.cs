namespace JoshWangTopicApp
{
	partial class FormFeedback
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFeedback));
			this.label1 = new System.Windows.Forms.Label();
			this.labPRNumber = new System.Windows.Forms.Label();
			this.labTitle = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(109, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(222, 74);
			this.label1.TabIndex = 0;
			this.label1.Text = "PRvalue";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// labPRNumber
			// 
			this.labPRNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labPRNumber.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labPRNumber.ForeColor = System.Drawing.Color.Transparent;
			this.labPRNumber.Location = new System.Drawing.Point(39, 97);
			this.labPRNumber.Name = "labPRNumber";
			this.labPRNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.labPRNumber.Size = new System.Drawing.Size(352, 74);
			this.labPRNumber.TabIndex = 1;
			this.labPRNumber.Text = "(number)";
			this.labPRNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labTitle
			// 
			this.labTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labTitle.ForeColor = System.Drawing.Color.Transparent;
			this.labTitle.Location = new System.Drawing.Point(32, 188);
			this.labTitle.Name = "labTitle";
			this.labTitle.Size = new System.Drawing.Size(364, 80);
			this.labTitle.TabIndex = 0;
			this.labTitle.Text = "(Title)";
			this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormFeedback
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tomato;
			this.ClientSize = new System.Drawing.Size(426, 294);
			this.Controls.Add(this.labPRNumber);
			this.Controls.Add(this.labTitle);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormFeedback";
			this.Text = "FormFeedback";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFeedback_FormClosing);
			this.Load += new System.EventHandler(this.FormFeedback_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labPRNumber;
		private System.Windows.Forms.Label labTitle;
	}
}