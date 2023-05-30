namespace WarehouseProj
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Entry-Permission")]
    public partial class Entry_Permission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Permission_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Permission_date { get; set; }

        public int Ware_ID_fk { get; set; }

        public int Supp_ID_fk { get; set; }

        public int Product_code_fk { get; set; }

        [Column(TypeName = "date")]
        public DateTime Production_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime Expiration_date { get; set; }

        public int Product_Quantity { get; set; }

        public virtual Product Product { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
