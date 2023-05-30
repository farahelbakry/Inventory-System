namespace WarehouseProj
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProdMeasure")]
    public partial class ProdMeasure
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Prod_code_fk { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MeasureUnit { get; set; }

        public virtual Product Product { get; set; }
    }
}
