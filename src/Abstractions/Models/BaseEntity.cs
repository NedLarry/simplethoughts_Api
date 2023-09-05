using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; } = null!;

        public User? User { get; set; }

        public string CreatedBy { get; set; } = null!;

        public string ModifiedBy { get; set; } = null!;

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }
    }
}
