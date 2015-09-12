namespace AutekInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Authority")]
    public partial class Authority
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Authority()
        {
            M_Role_Auth = new HashSet<M_Role_Auth>();
        }

        [Key]
        public int auth_id { get; set; }

        [StringLength(50)]
        public string auth_code { get; set; }

        [Required]
        [StringLength(50)]
        public string auth_name { get; set; }

        [StringLength(50)]
        public string auth_remark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<M_Role_Auth> M_Role_Auth { get; set; }
    }
}
