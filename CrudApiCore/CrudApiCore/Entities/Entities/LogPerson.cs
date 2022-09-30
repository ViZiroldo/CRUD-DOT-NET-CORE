using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("LogPerson")]
    public class LogPerson
    {
        [Column("Event")]
        [MaxLength(255)]
        [Required]
        public string Event { get; set; }

        [Column("DateRegister")]
        [MaxLength(100)]
        [Required]
        public DateTime DateRegister { get; set; }

        [Column("UserId")]
        [MaxLength(100)]
        [Required]
        public string UserId { get; set; }

    }
}
