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
	public partial class Report2 : Form
	{
		Model1 Ent = new Model1();
		public Report2()
		{
			InitializeComponent();

		}

		private void Report2_Load(object sender, EventArgs e)
		{
			var ID = from d in Ent.Products
					 select d.Prod_code;
			foreach (var i in ID)
			{
				comboBox1.Items.Add(i);
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			int ID = int.Parse(comboBox1.Text);
			var wareproduct = from p in Ent.Ware_product where p.Prod_code_fk == ID select p;
			
			foreach(var p in wareproduct)
			{
				
				listBox1.Items.Add(p.Warehouse.Ware_name+"\t"+ "\t" + "\t" + "\t" + p.Warehouse.Ware_ID);
			}
			
		}
	}
}
