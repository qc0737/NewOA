namespace AutekInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Employee_Info
    {
        [Key]
        public int emp_id { get; set; }

        [StringLength(100)]
        public string emp_dept { get; set; }

        [StringLength(100)]
        public string emp_insti { get; set; }

        [StringLength(100)]
        public string emp_comp { get; set; }

        [StringLength(100)]
        public string emp_worknum { get; set; }

        [StringLength(100)]
        public string emp_cnname { get; set; }

        public DateTime? emp_entrydate { get; set; }

        [StringLength(100)]
        public string emp_email { get; set; }

        [StringLength(100)]
        public string emp_age { get; set; }

        [StringLength(100)]
        public string emp_identity { get; set; }

        [StringLength(100)]
        public string emp_workarea { get; set; }

        [StringLength(100)]
        public string emp_phone { get; set; }

        [StringLength(100)]
        public string emp_title { get; set; }

        [StringLength(100)]
        public string emp_sex { get; set; }

        [StringLength(100)]
        public string emp_isonworking { get; set; }
    }
}
