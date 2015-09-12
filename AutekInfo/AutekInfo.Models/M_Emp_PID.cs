namespace AutekInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_Emp_PID
    {
        public int id { get; set; }

        public int? emp_id { get; set; }

        public int? emp_pid { get; set; }
    }
}
