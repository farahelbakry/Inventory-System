namespace WarehouseProj
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            Entry_Permission = new HashSet<Entry_Permission>();
            ExitPermissions = new HashSet<ExitPermission>();
            Transfer_Product = new HashSet<Transfer_Product>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Supp_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Supp_name { get; set; }

        public int? Supp_homephone { get; set; }

        public int? Supp_fax { get; set; }

        public int Supp_phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Supp_email { get; set; }

        [StringLength(50)]
        public string Supp_website { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entry_Permission> Entry_Permission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExitPermission> ExitPermissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transfer_Product> Transfer_Product { get; set; }
    }
}
