using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class StateBL
    {
        public static List<State> GetAllState()
        {
            return DAL.StateDAL.GetStateALl(); 
        } 
    }
}
