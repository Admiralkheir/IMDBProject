namespace IMDBProject.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Actor")]
    public partial class Actor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Actor()
        {
            Film = new HashSet<Film>();
        }

        public short ActorID { get; set; }

        public short CountryID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        [Required]
        [StringLength(50)]
        public string ActorName { get; set; }

        [Required]
        [StringLength(50)]
        public string ActorSurname { get; set; }

        [Required]
        [StringLength(455)]
        public string ActorBiography { get; set; }

        public bool ActorGender { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(100)]
        public string ActorPhotoUrl { get; set; }

        public virtual Country Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Film> Film { get; set; }
    }
}
