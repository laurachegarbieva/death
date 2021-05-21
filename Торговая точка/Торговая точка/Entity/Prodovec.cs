namespace Торговая_точка.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Prodovec")]
    public partial class Prodovec
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int id_tochka { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string ferst_name { get; set; }

        [StringLength(50)]
        public string last_name { get; set; }

        [Required]
        [StringLength(20)]
        public string telefon { get; set; }

        public bool isdeleted { get; set; }

        public virtual Tochka Tochka { get; set; }
    }
}
