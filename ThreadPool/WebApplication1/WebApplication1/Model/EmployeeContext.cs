using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.WebApplication1.Model
{
    public partial class EmployeeContext : DbContext
    {
        public EmployeeContext()
        {
        }

        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CompanyDeptIncome> CompanyDeptIncome { get; set; }
        public virtual DbSet<EmpAdd> EmpAdd { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<OrgEmployye> OrgEmployye { get; set; }
        public virtual DbSet<SysUser> SysUser { get; set; }
        public virtual DbSet<UserDetail> UserDetail { get; set; }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer("Server=KELLGGNCPU0365\\SQLEXPRESS;Database=Employee;Trusted_Connection=True;");
        //            }
        //        }
        //public EmployeeContext(DbContextOptions<EmployeeContext> options)
        //: base(options)
        //{ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyDeptIncome>(entity =>
            {
                entity.ToTable("Company_Dept_Income");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompDeptName)
                    .HasColumnName("Comp_Dept_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.SaleYtd).HasColumnName("Sale_YTD");
            });

            modelBuilder.Entity<EmpAdd>(entity =>
            {
                entity.ToTable("Emp_Add");

                entity.HasIndex(e => e.Id)
                    .HasName("UQ__Emp_Add__3213E83E9C1DD1F8")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id").ValueGeneratedNever();
   

              

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<OrgEmployye>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("ORG_Employye");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.ManagerId)
                    .HasColumnName("ManagerID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("sysUser");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Fname).HasMaxLength(50);

                entity.Property(e => e.Lname).HasMaxLength(50);
            });
        }
    }
}
