using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class State
    {
        [Key]
        public int StateID { get; set; }
        public string Name { get; set; }

        //public virtual List<Country> Countries { get; set; }
    }
}
