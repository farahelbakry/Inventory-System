namespace WarehouseProj
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Warehouse")]
    public partial class Warehouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Warehouse()
        {
            Entry_Permission = new HashSet<Entry_Permission>();
            ExitPermissions = new HashSet<ExitPermission>();
            Transfer_Product = new HashSet<Transfer_Product>();
            Transfer_Product1 = new HashSet<Transfer_Product>();
            Ware_product = new HashSet<Ware_product>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ware_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Ware_name { get; set; }

        [Required]
        [StringLength(50)]
        public string Ware_address { get; set; }

        [StringLength(50)]
        public string Ware_manager { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entry_Permission> Entry_Permission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExitPermission> ExitPermissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transfer_Product> Transfer_Product { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transfer_Product> Transfer_Product1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ware_product> Ware_product { get; set; }
    }
}
