namespace AutekInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        [Key]
        public int menu_id { get; set; }

        [StringLength(50)]
        public string menu_icon { get; set; }

        [Required]
        [StringLength(100)]
        public string menu_name { get; set; }

        public int? menu_pid { get; set; }

        [StringLength(100)]
        public string menu_link { get; set; }

        public int? menu_sort { get; set; }

        public bool? menu_isshow { get; set; }
    }
}
