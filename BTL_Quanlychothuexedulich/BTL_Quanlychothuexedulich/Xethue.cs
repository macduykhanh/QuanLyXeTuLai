namespace BTL_Quanlychothuexedulich
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xethue")]
    public partial class Xethue
    {
        [Key]
        [StringLength(15)]
        public string Maxe { get; set; }

        [StringLength(15)]
        public string Makh { get; set; }

        public int? DongiaNgay { get; set; }

        [StringLength(10)]
        public string Bienso { get; set; }

        public virtual Khachhang Khachhang { get; set; }

        public virtual Thongtinxe Thongtinxe { get; set; }
    }
}
