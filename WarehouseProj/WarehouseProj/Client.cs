namespace WarehouseProj
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Client_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Client_name { get; set; }

        public int? Client_homephone { get; set; }

        public int? Client_fax { get; set; }

        public int Client_phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Client_email { get; set; }

        [StringLength(50)]
        public string Client_website { get; set; }
    }
}
