namespace Торговая_точка.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Postavshik")]
    public partial class Postavshik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Postavshik()
        {
            ZakazyPostavshikam = new HashSet<ZakazyPostavshikam>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZakazyPostavshikam> ZakazyPostavshikam { get; set; }
    }
}
