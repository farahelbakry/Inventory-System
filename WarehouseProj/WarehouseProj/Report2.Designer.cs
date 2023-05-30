namespace WarehouseProj
{
	partial class Report2
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(343, 90);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(172, 24);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(264, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Product ID";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(267, 152);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(248, 180);
			this.listBox1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(223, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(340, 34);
			this.label2.TabIndex = 3;
			this.label2.Text = "Display Product Details";
			// 
			// Report2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Name = "Report2";
			this.Text = "Report2";
			this.Load += new System.EventHandler(this.Report2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label2;
	}
}