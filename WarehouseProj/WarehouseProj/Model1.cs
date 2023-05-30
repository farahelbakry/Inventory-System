using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WarehouseProj
{
	public partial class Model1 : DbContext
	{
		public Model1()
			: base("name=Model12")
		{
		}

		public virtual DbSet<Client> Clients { get; set; }
		public virtual DbSet<Entry_Permission> Entry_Permission { get; set; }
		public virtual DbSet<ExitPermission> ExitPermissions { get; set; }
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<Supplier> Suppliers { get; set; }
		public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
		public virtual DbSet<Transfer_Product> Transfer_Product { get; set; }
		public virtual DbSet<Ware_product> Ware_product { get; set; }
		public virtual DbSet<Warehouse> Warehouses { get; set; }
		public virtual DbSet<ProdMeasure> ProdMeasures { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Client>()
				.Property(e => e.Client_name)
				.IsUnicode(false);

			modelBuilder.Entity<Client>()
				.Property(e => e.Client_email)
				.IsUnicode(false);

			modelBuilder.Entity<Client>()
				.Property(e => e.Client_website)
				.IsUnicode(false);

			modelBuilder.Entity<Product>()
				.Property(e => e.Prod_name)
				.IsUnicode(false);

			modelBuilder.Entity<Product>()
				.HasMany(e => e.Entry_Permission)
				.WithRequired(e => e.Product)
				.HasForeignKey(e => e.Product_code_fk)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Product>()
				.HasMany(e => e.ExitPermissions)
				.WithRequired(e => e.Product)
				.HasForeignKey(e => e.Product_code_fk)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Product>()
				.HasMany(e => e.ProdMeasures)
				.WithRequired(e => e.Product)
				.HasForeignKey(e => e.Prod_code_fk)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Product>()
				.HasMany(e => e.Transfer_Product)
				.WithRequired(e => e.Product)
				.HasForeignKey(e => e.Prod_code_fk)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Product>()
				.HasMany(e => e.Ware_product)
				.WithRequired(e => e.Product)
				.HasForeignKey(e => e.Prod_code_fk)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Supplier>()
				.Property(e => e.Supp_name)
				.IsUnicode(false);

			modelBuilder.Entity<Supplier>()
				.Property(e => e.Supp_email)
				.IsUnicode(false);

			modelBuilder.Entity<Supplier>()
				.Property(e => e.Supp_website)
				.IsUnicode(false);

			modelBuilder.Entity<Supplier>()
				.HasMany(e => e.Entry_Permission)
				.WithRequired(e => e.Supplier)
				.HasForeignKey(e => e.Supp_ID_fk)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Supplier>()
				.HasMany(e => e.ExitPermissions)
				.WithRequired(e => e.Supplier)
				.HasForeignKey(e => e.Supp_ID_fk)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Supplier>()
				.HasMany(e => e.Transfer_Product)
				.WithRequired(e => e.Supplier)
				.HasForeignKey(e => e.Supp_ID_fk)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Warehouse>()
				.Property(e => e.Ware_name)
				.IsUnicode(false);

			modelBuilder.Entity<Warehouse>()
				.Property(e => e.Ware_address)
				.IsUnicode(false);

			modelBuilder.Entity<Warehouse>()
				.Property(e => e.Ware_manager)
				.IsUnicode(false);

			modelBuilder.Entity<Warehouse>()
				.HasMany(e => e.Entry_Permission)
				.WithRequired(e => e.Warehouse)
				.HasForeignKey(e => e.Ware_ID_fk)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Warehouse>()
				.HasMany(e => e.ExitPermissions)
				.WithRequired(e => e.Warehouse)
				.HasForeignKey(e => e.Ware_ID_fk)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Warehouse>()
				.HasMany(e => e.Transfer_Product)
				.WithRequired(e => e.Warehouse)
				.HasForeignKey(e => e.To_Ware_ID)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Warehouse>()
				.HasMany(e => e.Transfer_Product1)
				.WithRequired(e => e.Warehouse1)
				.HasForeignKey(e => e.From_Ware_ID)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Warehouse>()
				.HasMany(e => e.Ware_product)
				.WithRequired(e => e.Warehouse)
				.HasForeignKey(e => e.Ware_id_fk)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<ProdMeasure>()
				.Property(e => e.MeasureUnit)
				.IsUnicode(false);
		}
	}
}
