namespace WarehouseProj
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Entry_Permission = new HashSet<Entry_Permission>();
            ExitPermissions = new HashSet<ExitPermission>();
            ProdMeasures = new HashSet<ProdMeasure>();
            Transfer_Product = new HashSet<Transfer_Product>();
            Ware_product = new HashSet<Ware_product>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Prod_code { get; set; }

        [Required]
        [StringLength(50)]
        public string Prod_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entry_Permission> Entry_Permission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExitPermission> ExitPermissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdMeasure> ProdMeasures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transfer_Product> Transfer_Product { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ware_product> Ware_product { get; set; }
    }
}
