namespace AutekInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Emp_Dept
    {
        [Key]
        public int dept_id { get; set; }

        [StringLength(50)]
        public string dept_name { get; set; }

        [StringLength(50)]
        public string dept_code { get; set; }

        public int? dept_pid { get; set; }

        public int? dept_order { get; set; }
    }
}
