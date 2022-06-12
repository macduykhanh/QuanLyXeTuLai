namespace BTL_Quanlychothuexedulich
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phieuthuexe")]
    public partial class Phieuthuexe
    {
        [Key]
        [StringLength(15)]
        public string Maphieu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaythue { get; set; }

        [StringLength(15)]
        public string Makh { get; set; }

        [StringLength(15)]
        public string Maxe { get; set; }

        public int? Songaythue { get; set; }

        public virtual Khachhang Khachhang { get; set; }
    }
}
