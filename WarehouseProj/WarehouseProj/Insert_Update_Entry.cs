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
	public partial class Insert_Update_Entry : Form
	{
		Model1 Ent = new Model1();
		public Insert_Update_Entry()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Entry_Permission EP= new Entry_Permission();
			EP.Permission_ID = int.Parse(textBox1.Text);
			EP.Permission_date = dateTimePicker1.Value;
			EP.Expiration_date= dateTimePicker2.Value;
			EP.Production_date = dateTimePicker3.Value;
			EP.Ware_ID_fk= int.Parse(textBox3.Text);
			EP.Supp_ID_fk = int.Parse(textBox7.Text);
			EP.Product_Quantity= int.Parse(textBox8.Text);
			EP.Product_code_fk = int.Parse(textBox4.Text);
			
			var data = (from d in Ent.Entry_Permission where d.Permission_ID == EP.Permission_ID select d);
			var x = (from d in Ent.Ware_product where d.Ware_id_fk == EP.Ware_ID_fk && d.Prod_code_fk == EP.Product_code_fk select d).FirstOrDefault();
			Ent.Entry_Permission.Add(EP);
	
			if (x != null)
			{
				x.Prod_Quantity+= EP.Product_Quantity;
			
				MessageBox.Show((x.Prod_Quantity).ToString());
				Ent.SaveChanges();
				MessageBox.Show("Imported Successfully");
				

			}
			else
			{
				MessageBox.Show("error occured");
			}


		}

		private void button2_Click(object sender, EventArgs e)
		{
			int ID = int.Parse(textBox1.Text);

			Entry_Permission wh = (Ent.Entry_Permission.Where(d => d.Permission_ID == ID).Select(d => d)).FirstOrDefault();
			//var x = (from d in Ent.Ware_product where d.Ware_id_fk == wh.Ware_ID_fk && d.Prod_code_fk == wh.Product_code_fk select d).FirstOrDefault();
			//Ware_product wp=new Ware_product();	
			if (wh != null)
			{
				wh.Permission_date = dateTimePicker1.Value;
				wh.Expiration_date = dateTimePicker2.Value;
				wh.Production_date = dateTimePicker3.Value;
				wh.Ware_ID_fk = int.Parse(textBox3.Text);
				wh.Supp_ID_fk = int.Parse(textBox7.Text);
				wh.Product_Quantity = int.Parse(textBox8.Text);
				wh.Product_code_fk = int.Parse(textBox4.Text);
				
				//wh.Product_code_fk = wp.Prod_code_fk;
				//wh.Ware_ID_fk = wp.Ware_id_fk;
				//listBox1.Items.Clear();
				Ent.SaveChanges();
				MessageBox.Show("Updated Successfully");
				//textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
			}
			else
			{
				MessageBox.Show("Invalid Data");
			}
			
		}

	}
}
