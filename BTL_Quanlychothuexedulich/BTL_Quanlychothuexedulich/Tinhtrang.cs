namespace BTL_Quanlychothuexedulich
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Table("Tinhtrang")]
    public partial class Tinhtrang
    {
        [Key]
        [StringLength(155)]
        public string tinhtrang { get; set; }
    }
}
