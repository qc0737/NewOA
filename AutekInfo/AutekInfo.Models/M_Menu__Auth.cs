namespace AutekInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_Menu__Auth
    {
        [Key]
        public int m_menu_auth_id { get; set; }

        public int? menu_id { get; set; }

        public int? auth_id { get; set; }
    }
}
