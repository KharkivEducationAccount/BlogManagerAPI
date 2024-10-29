using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogManager.Models
{
    public record Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid BlogPostId { get; set; }
    }

}
