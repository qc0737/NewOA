namespace AutekInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Emp_Role
    {
        [StringLength(50)]
        public string role_code { get; set; }

        [StringLength(50)]
        public string role_name { get; set; }

        [StringLength(500)]
        public string role_describe { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int emp_id { get; set; }

        [StringLength(100)]
        public string emp_cnname { get; set; }
    }
}
