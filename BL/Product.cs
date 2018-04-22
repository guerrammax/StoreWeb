using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Product
    {
        public static Entities.BlogPost GetByID(int ID)
        {
            return DAL.Repository.GetBloPotsByID(ID);
        }
    }
}
