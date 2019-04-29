namespace IMDBProject.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Film")]
    public partial class Film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Film()
        {
            Rating = new HashSet<Rating>();
            Actor = new HashSet<Actor>();
            Category = new HashSet<Category>();
            Country = new HashSet<Country>();
            Director = new HashSet<Director>();
        }

        public short FilmID { get; set; }

        public short LanguageID { get; set; }

        [Required]
        [StringLength(50)]
        public string FilmName { get; set; }

        [Required]
        [StringLength(455)]
        public string FilmSummary { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }



        [Required]
        [StringLength(100)]
        public string PosterUrl { get; set; }

        public virtual Language Language { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rating> Rating { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actor> Actor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category> Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Country> Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Director> Director { get; set; }


    }
}
