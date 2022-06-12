namespace BTL_Quanlychothuexedulich
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Taikhoan")]
    public partial class Taikhoan
    {
        [Key]
        [Column("Taikhoan")]
        [StringLength(15)]
        public string Taikhoan1 { get; set; }

        [StringLength(15)]
        public string Matkhau { get; set; }

        [StringLength(2)]
        public string Quyen { get; set; }
    }
}
