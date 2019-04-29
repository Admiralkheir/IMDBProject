namespace IMDBProject.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Director")]
    public partial class Director
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Director()
        {
            Film = new HashSet<Film>();
        }

        public short DirectorID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public short CountryID { get; set; }

        [Required]
        [StringLength(50)]
        public string DirectorName { get; set; }

        [Required]
        [StringLength(50)]
        public string DirectorSurname { get; set; }

        public bool Gender { get; set; }

        [Required]
        [StringLength(455)]
        public string DirectorBiography { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(100)]
        public string PhotoUrl { get; set; }

        public virtual Country Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Film> Film { get; set; }
    }
}
