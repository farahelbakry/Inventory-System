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
	public partial class Report3 : Form
	{
		Model1 Ent=new Model1();	
		public Report3()
		{
			InitializeComponent();
		}
		Transfer tr= new Transfer();	
		private void button1_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			var transfer = (from d in Ent.Transfer_Product select d);
			var date1 = dateTimePicker1.Value;
			var date2 = dateTimePicker2.Value;
			foreach(var i in transfer)
			{
				if (i.Transfer_date > date1 && i.Transfer_date < date2)
				{
					listBox1.Items.Add("Transfer ID"+"\t"+ "\t" + i.Transfer_ID);
					listBox1.Items.Add("Transfer Date" + "\t" + "\t" + i.Transfer_date);
				}
			}
			
		}
	}
}
