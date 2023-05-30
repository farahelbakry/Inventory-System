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
	public partial class Form1 : Form
	{
		Model1 Ent = new Model1();
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Warehouse wh = new Warehouse();
			wh.Ware_ID = int.Parse(textBox1.Text);
			wh.Ware_name = textBox2.Text;
			wh.Ware_address = textBox3.Text;
			wh.Ware_manager = textBox4.Text;
			var AvailableID = (from d in Ent.Warehouses where d.Ware_ID == wh.Ware_ID select d).FirstOrDefault();
			if (AvailableID == null)
			{
				Ent.Warehouses.Add(wh);
				Ent.SaveChanges();
				MessageBox.Show("Inserted Successfully");
				textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
			}
			else
			{
				MessageBox.Show("Invalid Data");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int ID = int.Parse(textBox1.Text);

			Warehouse wh = (Ent.Warehouses.Where(d => d.Ware_ID == ID).Select(d => d)).FirstOrDefault();
			if (wh != null)
			{
				wh.Ware_name = textBox2.Text;
				wh.Ware_address = textBox3.Text;
				wh.Ware_manager = textBox4.Text;
				listBox1.Items.Clear();
				Ent.SaveChanges();
				MessageBox.Show("Updated Successfully");
				textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
			}
			else
			{
				MessageBox.Show("Invalid Data");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				Ware_product wp = new Ware_product();
				Product p = new Product();
				p.Prod_code = int.Parse(textBox5.Text);
				p.Prod_name = textBox6.Text;
				wp.Ware_id_fk = int.Parse(textBox7.Text);
				wp.Prod_code_fk = p.Prod_code;
				var AvailableID = (from d in Ent.Products where d.Prod_code == p.Prod_code select d).FirstOrDefault();
				if (AvailableID == null)
				{
					Ent.Products.Add(p);
					Ent.Ware_product.Add(wp);
					Ent.SaveChanges();
					MessageBox.Show("Inserted Successfully");
					textBox5.Text = textBox6.Text = textBox7.Text = "";
				}
				else
				{
					MessageBox.Show("Invalid Data");
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int code = int.Parse(textBox5.Text);
			Product pd = (Ent.Products.Where(d => d.Prod_code == code).Select(d => d)).FirstOrDefault();
			if (pd != null)
			{
				pd.Prod_code = int.Parse(textBox5.Text);
				pd.Prod_name = textBox6.Text;
				//pd.Prod_Unit = textBox7.Text;
				listBox1.Items.Clear();
				Ent.SaveChanges();
				MessageBox.Show("Updated Successfully");
				textBox5.Text = textBox6.Text = textBox7.Text = "";
			}
			else
			{
				MessageBox.Show("Invalid Data");
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Supplier sp = new Supplier();

			sp.Supp_id = int.Parse(textBox8.Text);
			sp.Supp_name = textBox9.Text;
			sp.Supp_homephone = int.Parse(textBox10.Text);
			sp.Supp_fax = int.Parse(textBox11.Text);
			sp.Supp_phone = int.Parse(textBox12.Text);
			sp.Supp_website = textBox13.Text;
			sp.Supp_email = textBox14.Text;


			var AvailableID = (from d in Ent.Suppliers where d.Supp_id == sp.Supp_id select d).FirstOrDefault();
			if (AvailableID == null)
			{
				Ent.Suppliers.Add(sp);
				Ent.SaveChanges();
				MessageBox.Show("Inserted Successfully");
				textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = textBox12.Text = textBox13.Text = textBox14.Text = "";
			}
			else
			{
				MessageBox.Show("Invalid Data");
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			int ID = int.Parse(textBox8.Text);
			Supplier sp = (Ent.Suppliers.Where(d => d.Supp_id == ID).Select(d => d)).FirstOrDefault();
			if (sp != null)
			{
				sp.Supp_id = int.Parse(textBox8.Text);
				sp.Supp_name = textBox9.Text;
				sp.Supp_homephone = int.Parse(textBox10.Text);
				sp.Supp_fax = int.Parse(textBox11.Text);
				sp.Supp_phone = int.Parse(textBox12.Text);
				sp.Supp_website = textBox13.Text;
				sp.Supp_email = textBox14.Text;
				listBox1.Items.Clear();
				Ent.SaveChanges();
				MessageBox.Show("Updated Successfully");
				textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = textBox12.Text = textBox13.Text = textBox14.Text = "";
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Client c = new Client();

			c.Client_id = int.Parse(textBox15.Text);
			c.Client_name = textBox16.Text;
			c.Client_homephone = int.Parse(textBox17.Text);
			c.Client_fax = int.Parse(textBox18.Text);
			c.Client_phone = int.Parse(textBox19.Text);
			c.Client_website = textBox20.Text;
			c.Client_email = textBox21.Text;


			var AvailableID = (from d in Ent.Clients where d.Client_id == c.Client_id select d).FirstOrDefault();
			if (AvailableID == null)
			{
				Ent.Clients.Add(c);
				Ent.SaveChanges();
				MessageBox.Show("Inserted Successfully");
				textBox21.Text = textBox20.Text = textBox19.Text = textBox18.Text = textBox17.Text = textBox16.Text = textBox15.Text = "";
			}
			else
			{
				MessageBox.Show("Invalid Data");
			}

		}

		private void button8_Click(object sender, EventArgs e)
		{
			int ID = int.Parse(textBox15.Text);
			Client c = (Ent.Clients.Where(d => d.Client_id == ID).Select(d => d)).FirstOrDefault();
			if (c != null)
			{
				c.Client_id = int.Parse(textBox15.Text);
				c.Client_name = textBox16.Text;
				c.Client_homephone = int.Parse(textBox17.Text);
				c.Client_fax = int.Parse(textBox18.Text);
				c.Client_phone = int.Parse(textBox19.Text);
				c.Client_website = textBox20.Text;
				c.Client_email = textBox21.Text;

				listBox1.Items.Clear();
				Ent.SaveChanges();
				MessageBox.Show("Updated Successfully");
				textBox21.Text = textBox20.Text = textBox19.Text = textBox18.Text = textBox17.Text = textBox16.Text = textBox15.Text = "";
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			Insert_Update_Entry ins = new Insert_Update_Entry();
			DialogResult dlg_Result;
			dlg_Result = ins.ShowDialog();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			Insert_Update_Exit ins = new Insert_Update_Exit();
			DialogResult dlg_Result;
			dlg_Result = ins.ShowDialog();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			Transfer ins = new Transfer();
			DialogResult dlg_Result;
			dlg_Result = ins.ShowDialog();
		}

		private void button12_Click(object sender, EventArgs e)
		{
			Reports ins = new Reports();
			DialogResult dlg_Result;
			dlg_Result = ins.ShowDialog();
		}
	}
}
