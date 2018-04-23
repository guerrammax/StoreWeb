using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [MetadataType(typeof(Metadata))]
    partial class BlogPost
    {
        private sealed class Metadata
        {
            [Required]
            public string Titulo { get; set; }
        } 
    }
}
