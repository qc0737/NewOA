namespace AutekInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_Role_Auth
    {
        [Key]
        public int m_role_auth_id { get; set; }

        public int role_id { get; set; }

        public int auth_id { get; set; }

        public virtual Authority Authority { get; set; }

        public virtual Emp_Roles Emp_Roles { get; set; }
    }
}
