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
	public partial class Report4 : Form
	{
		Model1 Ent=new Model1();	
		public Report4()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			var transfer = (from d in Ent.Entry_Permission select d);
			var date1 = dateTimePicker1.Value;
			var date2 = dateTimePicker2.Value;
			foreach (var i in transfer)
			{
				if (i.Permission_date > date1 && i.Permission_date < date2)
				{
					listBox1.Items.Add("Product Code" + "\t" + "\t" + i.Product_code_fk);
					listBox1.Items.Add("Permission ID" + "\t" + "\t" + i.Permission_ID);
				}
			}
		}
	}
}
