using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseProj
{
	public partial class Reports : Form
	{
		public Reports()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Report1 ins = new Report1();
			DialogResult dlg_Result;
			dlg_Result = ins.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Report2 ins = new Report2();
			DialogResult dlg_Result;
			dlg_Result = ins.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Report3 ins = new Report3();
			DialogResult dlg_Result;
			dlg_Result = ins.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Report4 ins = new Report4();
			DialogResult dlg_Result;
			dlg_Result = ins.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Report5 ins = new Report5();
			DialogResult dlg_Result;
			dlg_Result = ins.ShowDialog();
		}
	}
}
