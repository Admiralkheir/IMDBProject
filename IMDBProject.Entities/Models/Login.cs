namespace IMDBProject.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        public short LoginID { get; set; }

        public short UserID { get; set; }

        [Required]
        [StringLength(15)]
        public string Password { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual User User { get; set; }
    }
}
