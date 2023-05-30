namespace WarehouseProj
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transfer_Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Transfer_ID { get; set; }

        public int To_Ware_ID { get; set; }

        public int Supp_ID_fk { get; set; }

        public int Prod_code_fk { get; set; }

        public int Prod_quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Production_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime Expiration_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Transfer_date { get; set; }

        public int From_Ware_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Permission_Date { get; set; }

        public virtual Product Product { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual Warehouse Warehouse { get; set; }

        public virtual Warehouse Warehouse1 { get; set; }
    }
}
