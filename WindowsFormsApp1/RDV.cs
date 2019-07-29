namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RDV")]
    public partial class RDV
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nom { get; set; }

        [Required]
        [StringLength(50)]
        public string prenom { get; set; }

        [Required]
        [StringLength(10)]
        public string num { get; set; }

        [StringLength(50)]
        public string mail { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }
    }
}
