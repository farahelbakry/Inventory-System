namespace WarehouseProj
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExitPermission")]
    public partial class ExitPermission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Permission_ID { get; set; }

        public int Ware_ID_fk { get; set; }

        public int Supp_ID_fk { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Permission_Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime Production_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Expiration_date { get; set; }

        public int Production_Quantity { get; set; }

        public int Product_code_fk { get; set; }

        public virtual Product Product { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
