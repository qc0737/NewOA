namespace AutekInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Emp_Account
    {
        [Key]
        [StringLength(50)]
        public string loginid { get; set; }

        [StringLength(50)]
        public string pwd { get; set; }

        [StringLength(100)]
        public string status { get; set; }

        [StringLength(50)]
        public string lastloginip { get; set; }

        public DateTime? lastlogindate { get; set; }

        public int? sysstatus { get; set; }

        public int? updater { get; set; }

        public DateTime? updatedata { get; set; }
    }
}
