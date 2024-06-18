using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Models
{
    public class Comment : BaseEntity
    {
        [EmailAddress]
        public string EmailAddress { get; set; } = null!;


        [Required]
        [StringLength(100)]
        public string Text { get; set; } = null!;
    }
}
