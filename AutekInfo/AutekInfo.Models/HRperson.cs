namespace AutekInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HRperson")]
    public partial class HRperson
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string dept { get; set; }

        [StringLength(20)]
        public string dept_id { get; set; }

        [StringLength(20)]
        public string yuan { get; set; }

        [StringLength(10)]
        public string yuan_id { get; set; }

        [StringLength(20)]
        public string gs { get; set; }

        [StringLength(10)]
        public string gs_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string work_id { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string name { get; set; }

        [StringLength(10)]
        public string card_id { get; set; }

        [StringLength(20)]
        public string csrq { get; set; }

        public DateTime? gzrq { get; set; }

        [StringLength(30)]
        public string gzzw { get; set; }

        public DateTime? sxrq { get; set; }

        public DateTime? zgzrq { get; set; }

        [StringLength(2)]
        public string xb { get; set; }

        [StringLength(50)]
        public string zw { get; set; }

        [StringLength(50)]
        public string zwdm { get; set; }

        [StringLength(20)]
        public string gzh { get; set; }

        [StringLength(100)]
        public string gzd { get; set; }

        [StringLength(20)]
        public string lyxs { get; set; }

        [StringLength(20)]
        public string lyqd { get; set; }

        public DateTime? zzrq { get; set; }

        public DateTime? yzzrq { get; set; }

        public DateTime? cjgzrq { get; set; }

        [StringLength(200)]
        public string zgzs { get; set; }

        [StringLength(100)]
        public string zhic { get; set; }

        [StringLength(18)]
        public string sfz_no { get; set; }

        public int? age { get; set; }

        [StringLength(150)]
        public string photo { get; set; }

        [StringLength(20)]
        public string mz { get; set; }

        [StringLength(20)]
        public string zzmm { get; set; }

        [StringLength(20)]
        public string hyzk { get; set; }

        [StringLength(20)]
        public string jkzk { get; set; }

        [StringLength(10)]
        public string sg { get; set; }

        [StringLength(20)]
        public string hklx { get; set; }

        [StringLength(20)]
        public string jg { get; set; }

        [StringLength(300)]
        public string hjdz { get; set; }

        [StringLength(300)]
        public string jzdz { get; set; }

        [StringLength(30)]
        public string dh { get; set; }

        [StringLength(30)]
        public string sj { get; set; }

        [StringLength(20)]
        public string lxr { get; set; }

        [StringLength(50)]
        public string lxrsj { get; set; }

        [StringLength(50)]
        public string PCaccount { get; set; }

        [StringLength(50)]
        public string zhideng { get; set; }

        [StringLength(20)]
        public string qq { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public DateTime? lzrq { get; set; }

        [StringLength(10)]
        public string lzfs { get; set; }

        [StringLength(300)]
        public string lzyy { get; set; }

        public short? bz { get; set; }

        public short? dangan { get; set; }

        public short? jthk { get; set; }

        [StringLength(20)]
        public string sblx { get; set; }

        [StringLength(50)]
        public string sbdm { get; set; }

        public short? hmd { get; set; }

        [StringLength(100)]
        public string hmdyy { get; set; }

        [StringLength(150)]
        public string sjdw { get; set; }

        [StringLength(500)]
        public string remark { get; set; }

        [StringLength(50)]
        public string m1 { get; set; }

        [StringLength(50)]
        public string m2 { get; set; }

        [StringLength(500)]
        public string m3 { get; set; }

        [StringLength(50)]
        public string m4 { get; set; }

        [StringLength(50)]
        public string m5 { get; set; }

        [StringLength(50)]
        public string m6 { get; set; }

        [StringLength(50)]
        public string m7 { get; set; }

        [StringLength(50)]
        public string m8 { get; set; }

        [StringLength(50)]
        public string m9 { get; set; }

        [StringLength(50)]
        public string m10 { get; set; }

        public DateTime? CrtDate { get; set; }

        [StringLength(20)]
        public string CrtName { get; set; }

        public DateTime? UpdDate { get; set; }

        [StringLength(20)]
        public string UpdName { get; set; }

        public DateTime? UpdDateZZ { get; set; }

        [StringLength(20)]
        public string UpdNameZZ { get; set; }

        [StringLength(20)]
        public string UpdNameLZ { get; set; }

        public DateTime? UpdDateLZ { get; set; }

        [StringLength(20)]
        public string UpdNameHMD { get; set; }

        public DateTime? UpdDateHMD { get; set; }

        public int? gklz { get; set; }
    }
}
