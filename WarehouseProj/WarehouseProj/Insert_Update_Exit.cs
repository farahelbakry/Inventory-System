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
	public partial class Insert_Update_Exit : Form
	{
		Model1 Ent = new Model1();
		public Insert_Update_Exit()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ExitPermission EP = new ExitPermission();
			EP.Permission_ID = int.Parse(textBox1.Text);
			EP.Permission_Date = dateTimePicker1.Value;
			EP.Expiration_date = dateTimePicker2.Value;
			EP.Production_date = dateTimePicker3.Value;
			EP.Ware_ID_fk = int.Parse(textBox3.Text);
			EP.Supp_ID_fk = int.Parse(textBox4.Text);
			EP.Production_Quantity = int.Parse(textBox5.Text);
			EP.Product_code_fk = int.Parse(textBox4.Text);
			
			
			var data = (from d in Ent.ExitPermissions where d.Permission_ID == EP.Permission_ID select d);
			var x = (from d in Ent.Ware_product where d.Ware_id_fk == EP.Ware_ID_fk && d.Prod_code_fk == EP.Product_code_fk select d).FirstOrDefault();
			
			Ent.ExitPermissions.Add(EP);

			if (x != null)
			{
				x.Prod_Quantity -= EP.Production_Quantity;
				
				MessageBox.Show((x.Prod_Quantity).ToString());
				Ent.SaveChanges();
				MessageBox.Show("Exported Successfully");
			}
			else
			{
				MessageBox.Show("error occured");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int ID = int.Parse(textBox1.Text);

			ExitPermission EP = (Ent.ExitPermissions.Where(d => d.Permission_ID == ID).Select(d => d)).FirstOrDefault();
			//var x = (from d in Ent.Ware_product where d.Ware_id_fk == wh.Ware_ID_fk && d.Prod_code_fk == wh.Product_code_fk select d).FirstOrDefault();
			//Ware_product wp=new Ware_product();	
			if (EP != null)
			{
				EP.Permission_ID = int.Parse(textBox1.Text);
				EP.Permission_Date = dateTimePicker1.Value;
				EP.Expiration_date = dateTimePicker2.Value;
				EP.Production_date = dateTimePicker3.Value;
				EP.Ware_ID_fk = int.Parse(textBox3.Text);
				EP.Supp_ID_fk = int.Parse(textBox4.Text);
				EP.Production_Quantity = int.Parse(textBox5.Text);
				EP.Product_code_fk = int.Parse(textBox4.Text);

				
				Ent.SaveChanges();
				MessageBox.Show("Updated Successfully");
			
			}
			else
			{
				MessageBox.Show("Invalid Data");
			}
		}
	}
}
