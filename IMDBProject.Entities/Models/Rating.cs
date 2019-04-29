namespace IMDBProject.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rating")]
    public partial class Rating
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short FilmID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short UserID { get; set; }

        [Required]
        [StringLength(280)]
        public string Comment { get; set; }

        public byte Point { get; set; }


        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Film Film { get; set; }

        public virtual User User { get; set; }
    }
}
