using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarehouseProj
{
	public partial class Report1 : Form
	{
		Model1 Ent=new Model1();
		public Report1()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			int ID = int.Parse(comboBox1.Text);
			var warehouse = (from d in Ent.Warehouses where d.Ware_ID == ID select d).FirstOrDefault();
			var Wareproduct = (from d in Ent.Ware_product where d.Ware_id_fk == ID select d);
			
			 foreach(var i in Wareproduct)
			 {
				listBox1.Items.Add(i.Product.Prod_name + "\t" + i.Prod_Quantity);
				
			 }
			 if(warehouse != null)
			 {
				listBox1.Items.Add("Warehouse ID" + "\t" + "\t" + "\t" + warehouse.Ware_ID.ToString());
				listBox1.Items.Add("Warehouse Name" + "\t" + "\t" + "\t" + warehouse.Ware_name);
				listBox1.Items.Add("Warehouse Manager" + "\t" + "\t" + warehouse.Ware_manager);
				listBox1.Items.Add("Warehouse Address" + "\t" + "\t" + warehouse.Ware_address);
				

			 }

		}

		private void Report1_Load(object sender, EventArgs e)
		{
			var ID = from d in Ent.Warehouses
					   select d.Ware_ID;
			foreach (var i in ID)
			{
				comboBox1.Items.Add(i);
			}
		}
	}
}
