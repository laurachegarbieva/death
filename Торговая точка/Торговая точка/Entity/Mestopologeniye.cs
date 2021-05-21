namespace Торговая_точка.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mestopologeniye")]
    public partial class Mestopologeniye
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int id_postavshik { get; set; }

        public int id_tochka { get; set; }

        public int id_organizaciya { get; set; }

        [Required]
        [StringLength(50)]
        public string gorod { get; set; }

        [Required]
        [StringLength(50)]
        public string ulica { get; set; }

        [Required]
        [StringLength(50)]
        public string nomer_doma { get; set; }

        public bool isdeleted { get; set; }

        public virtual Orgnizaciya Orgnizaciya { get; set; }

        public virtual Tochka Tochka { get; set; }
    }
}
