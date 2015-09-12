namespace AutekInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee_Info
    {
        [Key]
        public int emp_id { get; set; }

        [StringLength(50)]
        public string loginid { get; set; }

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

        [StringLength(100)]
        public string emp_cardnum { get; set; }

        public DateTime? emp_birthdate { get; set; }

        public DateTime? emp_entrydate { get; set; }

        [StringLength(100)]
        public string emp_entrytitle { get; set; }

        public DateTime? emp_practicedate { get; set; }

        public DateTime? emp_lastdate { get; set; }

        [StringLength(100)]
        public string emp_sex { get; set; }

        [StringLength(100)]
        public string emp_title { get; set; }

        [StringLength(100)]
        public string emp_type { get; set; }

        [StringLength(100)]
        public string emp_workarea { get; set; }

        [StringLength(100)]
        public string emp_luyongfangshi { get; set; }

        [StringLength(100)]
        public string emp_luyongqudao { get; set; }

        public DateTime? emp_cometruedate { get; set; }

        public DateTime? emp_yjcometruedate { get; set; }

        public DateTime? emp_beginworkdate { get; set; }

        [StringLength(100)]
        public string emp_workcertificate { get; set; }

        [StringLength(100)]
        public string emp_zhicheng { get; set; }

        [StringLength(100)]
        public string emp_identity { get; set; }

        [StringLength(100)]
        public string emp_age { get; set; }

        [StringLength(100)]
        public string emp_photolink { get; set; }

        [StringLength(100)]
        public string emp_minzhu { get; set; }

        [StringLength(100)]
        public string emp_zzmm { get; set; }

        [StringLength(100)]
        public string emp_marital { get; set; }

        [StringLength(100)]
        public string emp_healthstatus { get; set; }

        [StringLength(100)]
        public string emp_paiban { get; set; }

        [StringLength(100)]
        public string emp_hklx { get; set; }

        [StringLength(100)]
        public string emp_jiguan { get; set; }

        [StringLength(100)]
        public string emp_hujiaddr { get; set; }

        [StringLength(100)]
        public string emp_juzhuaddr { get; set; }

        [StringLength(100)]
        public string emp_tel { get; set; }

        [StringLength(100)]
        public string emp_phone { get; set; }

        [StringLength(100)]
        public string emp_lxr { get; set; }

        [StringLength(100)]
        public string emp_lxrphone { get; set; }

        [StringLength(100)]
        public string emp_zhideng { get; set; }

        [StringLength(100)]
        public string emp_QQ { get; set; }

        [StringLength(100)]
        public string emp_email { get; set; }

        public DateTime? emp_dimissdate { get; set; }

        [StringLength(100)]
        public string emp_dimisstype { get; set; }

        [StringLength(100)]
        public string emp_dismissremark { get; set; }

        [StringLength(100)]
        public string emp_isonworking { get; set; }

        [StringLength(100)]
        public string emp_iszda { get; set; }

        [StringLength(100)]
        public string emp_isjthk { get; set; }

        [StringLength(100)]
        public string emp_sblx { get; set; }

        [StringLength(100)]
        public string emp_sbnum { get; set; }

        [StringLength(100)]
        public string emp_isblacklist { get; set; }

        [StringLength(100)]
        public string emp_balcklistremark { get; set; }

        [StringLength(100)]
        public string emp_lastcomp { get; set; }

        [StringLength(100)]
        public string emp_remrak { get; set; }

        [StringLength(100)]
        public string emp_birthtype { get; set; }

        public DateTime? emp_real_brithdate { get; set; }

        [StringLength(100)]
        public string emp_jobtype { get; set; }

        [StringLength(100)]
        public string emp_banknum { get; set; }

        [StringLength(100)]
        public string emp_bank { get; set; }

        public DateTime? emp_createdate { get; set; }

        [StringLength(100)]
        public string emp_creater { get; set; }
    }
}
