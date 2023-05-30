namespace WarehouseProj
{
	partial class Report3
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
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(319, 97);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(192, 24);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(319, 145);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(192, 24);
			this.dateTimePicker2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(249, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Date 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(249, 151);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Date 2";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(233, 191);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(317, 180);
			this.listBox1.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.button1.Location = new System.Drawing.Point(252, 392);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(259, 47);
			this.button1.TabIndex = 5;
			this.button1.Text = "Display";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(364, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 17);
			this.label3.TabIndex = 6;
			// 
			// Report3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Name = "Report3";
			this.Text = "Report3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
	}
}