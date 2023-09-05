using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; } = null!;

        public virtual List<Thought> Thoughts { get; set; } = new List<Thought>();

        public virtual List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
