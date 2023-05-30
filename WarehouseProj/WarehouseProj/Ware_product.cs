namespace WarehouseProj
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ware_product
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ware_id_fk { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Prod_code_fk { get; set; }

        public int? Prod_Quantity { get; set; }

        public virtual Product Product { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
