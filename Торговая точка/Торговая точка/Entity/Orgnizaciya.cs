namespace Торговая_точка.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Orgnizaciya")]
    public partial class Orgnizaciya
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orgnizaciya()
        {
            Mestopologeniye = new HashSet<Mestopologeniye>();
            Tochka = new HashSet<Tochka>();
            ZakazyPostavshikam = new HashSet<ZakazyPostavshikam>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nazvaniye { get; set; }

        [Required]
        [StringLength(20)]
        public string telefon { get; set; }

        [Required]
        [StringLength(50)]
        public string name_director { get; set; }

        [Required]
        [StringLength(50)]
        public string ferst_name_director { get; set; }

        [StringLength(50)]
        public string last_name_director { get; set; }

        public bool isdeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mestopologeniye> Mestopologeniye { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tochka> Tochka { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZakazyPostavshikam> ZakazyPostavshikam { get; set; }
    }
}
