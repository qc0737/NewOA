namespace AutekInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Global_Config
    {
        [Key]
        public int gc_id { get; set; }

        public int? gc_type { get; set; }

        [StringLength(500)]
        public string gc_code { get; set; }

        [StringLength(500)]
        public string gc_name { get; set; }

        public int? gc_order { get; set; }

        [StringLength(500)]
        public string gc_distinct { get; set; }

        [StringLength(500)]
        public string gc_config1 { get; set; }

        [StringLength(500)]
        public string gc_config2 { get; set; }
    }
}
