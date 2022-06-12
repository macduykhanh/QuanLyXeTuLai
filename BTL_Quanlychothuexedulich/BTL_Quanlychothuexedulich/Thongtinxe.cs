namespace BTL_Quanlychothuexedulich
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thongtinxe")]
    public partial class Thongtinxe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Thongtinxe()
        {
            Xethues = new HashSet<Xethue>();
        }

        [Key]
        [StringLength(10)]
        public string Bienso { get; set; }

        [StringLength(10)]
        public string Hangxe { get; set; }

        [StringLength(15)]
        public string Tenxe { get; set; }

        [StringLength(10)]
        public string Loaixe { get; set; }

        [StringLength(10)]
        public string Mauson { get; set; }

        [StringLength(10)]
        public string Tinhtrang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Xethue> Xethues { get; set; }
    }
}
