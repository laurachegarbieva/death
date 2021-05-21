namespace Торговая_точка.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZakazyPostavshikam")]
    public partial class ZakazyPostavshikam
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int id_tovar { get; set; }

        public int id_postavshiki { get; set; }

        public int id_organizacia { get; set; }

        [Required]
        [StringLength(50)]
        public string colichestvo { get; set; }

        public bool isdeleted { get; set; }

        public virtual Orgnizaciya Orgnizaciya { get; set; }

        public virtual Postavshik Postavshik { get; set; }

        public virtual Tovar Tovar { get; set; }
    }
}
