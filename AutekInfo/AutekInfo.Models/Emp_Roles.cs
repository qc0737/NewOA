namespace AutekInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Emp_Roles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Emp_Roles()
        {
            M_Role_Auth = new HashSet<M_Role_Auth>();
        }

        [Key]
        public int role_id { get; set; }

        [StringLength(50)]
        public string role_code { get; set; }

        [StringLength(50)]
        public string role_name { get; set; }

        [StringLength(500)]
        public string role_describe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<M_Role_Auth> M_Role_Auth { get; set; }
    }
}
