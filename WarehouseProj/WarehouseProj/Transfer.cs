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
	public partial class Transfer : Form
	{
		Model1 Ent=new Model1();
		public Transfer()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Transfer_Product transfer = new Transfer_Product();	

			transfer.Transfer_ID=int.Parse(textBox1.Text);	
			transfer.To_Ware_ID= int.Parse(textBox2.Text);
			transfer.From_Ware_ID= int.Parse(textBox3.Text);	
			transfer.Supp_ID_fk= int.Parse(textBox4.Text);	
			transfer.Prod_code_fk= int.Parse(textBox5.Text);	
			transfer.Prod_quantity= int.Parse(textBox6.Text);
			transfer.Production_date = dateTimePicker1.Value;
			transfer.Expiration_date= dateTimePicker2.Value;
			transfer.Transfer_date= dateTimePicker4.Value;
			transfer.Permission_Date = dateTimePicker3.Value;

			Ware_product ware_Product=new Ware_product();
			var x = (from d in Ent.Ware_product where d.Ware_id_fk == transfer.To_Ware_ID && d.Prod_code_fk == transfer.Prod_code_fk select d).FirstOrDefault();
			var y = (from d in Ent.Ware_product where d.Ware_id_fk == transfer.From_Ware_ID && d.Prod_code_fk == transfer.Prod_code_fk select d).FirstOrDefault();
			Ent.Transfer_Product.Add(transfer);
			if(x!=null && y != null)
			{
				x.Prod_Quantity+= transfer.Prod_quantity;
				y.Prod_Quantity-=transfer.Prod_quantity;
				Ent.SaveChanges();
				MessageBox.Show("Ok");
			}
			else
			{
				MessageBox.Show("error");
			}



		}
	}
}
