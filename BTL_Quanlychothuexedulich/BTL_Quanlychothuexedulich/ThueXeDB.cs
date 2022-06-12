using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BTL_Quanlychothuexedulich
{
    public partial class ThueXeDB : DbContext
    {
        public ThueXeDB()
            : base("name=ThueXeDB")
        {
        }

        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Phieuthuexe> Phieuthuexes { get; set; }
        public virtual DbSet<Taikhoan> Taikhoans { get; set; }
        public virtual DbSet<Thongtinxe> Thongtinxes { get; set; }
        public virtual DbSet<Xethue> Xethues { get; set; }
        public virtual DbSet<Loaixe> Loaixes { get; set; }
        public virtual DbSet<Tinhtrang> Tinhtrangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Taikhoan>()
                .Property(e => e.Quyen)
                .IsUnicode(false);
        }
    }
}
