namespace DreamCatcher.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Register")]
    public partial class Register
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string UserEmail { get; set; }

        [Required]
        [StringLength(20)]
        public string Country { get; set; }

        [StringLength(170)]
        public string Password { get; set; }

        [Required]
        public int Pin { get; set; }
    }
}
