namespace AutekInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Emp_History
    {
        [Key]
        public int e_his_id { get; set; }

        public DateTime? e_his_date { get; set; }

        public int? emp_id { get; set; }

        [StringLength(50)]
        public string e_his_field { get; set; }

        [StringLength(50)]
        public string e_his_fieldshow { get; set; }

        [StringLength(100)]
        public string e_his_oridata { get; set; }

        [StringLength(100)]
        public string e_his_newdata { get; set; }

        public int? e_his_chgerid { get; set; }

        public int? e_his_chgtype { get; set; }

        public DateTime? e_his_golivedate { get; set; }

        public bool? e_his_ishow { get; set; }

        [StringLength(500)]
        public string e_his_remark { get; set; }
    }
}
