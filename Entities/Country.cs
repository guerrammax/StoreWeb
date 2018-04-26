using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Country
    {
        public int ID { get; set; }
        public string cDescripcion { get; set; }
        public DateTime dBaja { get; set; }
        //public int StateID { get; set; }
        //public virtual State State { get; set; }
    }
}
