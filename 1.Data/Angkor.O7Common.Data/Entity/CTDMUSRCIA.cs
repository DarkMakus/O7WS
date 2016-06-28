using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Angkor.O7Common.Data.Entity
{
    [Table("CN01.CTDMUSRCIA")]
    public class CTDMUSRCIA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string CTUCCODCIA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CTUCCODSUC { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string CTUCCODUSR { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string CTUCCODSEC { get; set; }

        [StringLength(10)]
        public string CTUCCODIMP { get; set; }

        [StringLength(3)]
        public string CTUCCODCJA { get; set; }

        [StringLength(8)]
        public string CTUCCODBCO { get; set; }

        [StringLength(30)]
        public string CTUCNOMUSR { get; set; }

        public DateTime? CTUCFECING { get; set; }

        [StringLength(10)]
        public string CTUCNOMUOPE { get; set; }

        public DateTime? CTUCFECUOPE { get; set; }

        [StringLength(1)]
        public string CTUCFLGUOPE { get; set; }

        [StringLength(2)]
        public string CTUCCODPLA { get; set; }

        [StringLength(1)]
        public string CTUCCODCOM { get; set; }

        [StringLength(32)]
        public string CTUCPWDCLN { get; set; }

        [StringLength(32)]
        public string CTUCPWDSRV { get; set; }

        [StringLength(50)]
        public string CTUCCORREO { get; set; }

        [StringLength(8)]
        public string CTUCCODTRA { get; set; }

        [StringLength(10)]
        public string CTUCCODUSRP { get; set; }

        [StringLength(32)]
        public string CTUCPWDCLN2 { get; set; }

        [Column(TypeName = "long raw")]
        [MaxLength(2147483647)]
        public byte[] CTUCFIRUSR { get; set; }

        [StringLength(1)]
        public string CTUCFLGEST { get; set; }

        [StringLength(1)]
        public string CTUCACTIVO { get; set; }

        [StringLength(1)]
        public string CTUCCMBPSW { get; set; }

        [StringLength(1)]
        public string CTUCFLAPSW { get; set; }

        [StringLength(5)]
        public string CTUIDIOMA { get; set; }
    }
}
