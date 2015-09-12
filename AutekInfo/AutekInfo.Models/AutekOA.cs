namespace AutekInfo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AutekOA : DbContext
    {
        public AutekOA()
            : base("name=AutekOA")
        {
        }

        public virtual DbSet<Authority> Authority { get; set; }
        public virtual DbSet<Emp_Account> Emp_Account { get; set; }
        public virtual DbSet<Emp_Roles> Emp_Roles { get; set; }
        public virtual DbSet<Global_Config> Global_Config { get; set; }
        public virtual DbSet<M_Emp_PID> M_Emp_PID { get; set; }
        public virtual DbSet<M_Menu__Auth> M_Menu__Auth { get; set; }
        public virtual DbSet<M_Role_Auth> M_Role_Auth { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Emp_Dept> Emp_Dept { get; set; }
        public virtual DbSet<Emp_History> Emp_History { get; set; }
        public virtual DbSet<Employee_Info> Employee_Info { get; set; }
        public virtual DbSet<HRperson> HRperson { get; set; }
        public virtual DbSet<M_Emp_Role> M_Emp_Role { get; set; }
        public virtual DbSet<View_Emp_Role> View_Emp_Role { get; set; }
        public virtual DbSet<View_Employee_Info> View_Employee_Info { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authority>()
                .Property(e => e.auth_code)
                .IsUnicode(false);

            modelBuilder.Entity<Authority>()
                .HasMany(e => e.M_Role_Auth)
                .WithRequired(e => e.Authority)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Emp_Account>()
                .Property(e => e.pwd)
                .IsUnicode(false);

            modelBuilder.Entity<Emp_Account>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Emp_Account>()
                .Property(e => e.lastloginip)
                .IsUnicode(false);

            modelBuilder.Entity<Emp_Roles>()
                .Property(e => e.role_code)
                .IsUnicode(false);

            modelBuilder.Entity<Emp_Roles>()
                .HasMany(e => e.M_Role_Auth)
                .WithRequired(e => e.Emp_Roles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.menu_icon)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.menu_link)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.dept)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.dept_id)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.yuan)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.yuan_id)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.gs)
                .IsFixedLength();

            modelBuilder.Entity<HRperson>()
                .Property(e => e.gs_id)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.work_id)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.card_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.csrq)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.gzzw)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.xb)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.zw)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.gzh)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.sfz_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.photo)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.mz)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.zzmm)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.hyzk)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.jkzk)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.hjdz)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.jzdz)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.dh)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.sj)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.lxr)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.lxrsj)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.PCaccount)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.zhideng)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.lzfs)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.lzyy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.sblx)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.m1)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.m2)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.m3)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.m4)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.m5)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.m6)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.m7)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.m8)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.m9)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.m10)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.CrtName)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.UpdName)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.UpdNameZZ)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.UpdNameLZ)
                .IsUnicode(false);

            modelBuilder.Entity<HRperson>()
                .Property(e => e.UpdNameHMD)
                .IsUnicode(false);

            modelBuilder.Entity<View_Emp_Role>()
                .Property(e => e.role_code)
                .IsUnicode(false);
        }
    }
}
