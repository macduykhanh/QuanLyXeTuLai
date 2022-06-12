namespace BTL_Quanlychothuexedulich
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Khachhang")]
    public partial class Khachhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Khachhang()
        {
            Phieuthuexes = new HashSet<Phieuthuexe>();
            Xethues = new HashSet<Xethue>();
        }

        [Key]
        [StringLength(15)]
        public string Makh { get; set; }

        [StringLength(15)]
        public string Tenkh { get; set; }

        [StringLength(15)]
        public string Dienthoai { get; set; }

        [StringLength(15)]
        public string Diachi { get; set; }

        [StringLength(15)]
        public string Socmt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieuthuexe> Phieuthuexes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Xethue> Xethues { get; set; }
    }
}
