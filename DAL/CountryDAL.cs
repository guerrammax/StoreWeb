using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CountryDAL
    {
        public static List<Country> GetPaisAll()
        {
            List<Country> countries = null;

            using (var Context = new ContextDB())

                countries = Context.Countries.ToList();
                return countries;
        }
    }
}
