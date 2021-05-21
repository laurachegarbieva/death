namespace Торговая_точка.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tovar")]
    public partial class Tovar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tovar()
        {
            ZakazyPostavshikam = new HashSet<ZakazyPostavshikam>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string naimenovaniye { get; set; }

        [Required]
        [StringLength(50)]
        public string colichestvo { get; set; }

        [Column(TypeName = "money")]
        public decimal cena { get; set; }

        public bool isdeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZakazyPostavshikam> ZakazyPostavshikam { get; set; }
    }
}
