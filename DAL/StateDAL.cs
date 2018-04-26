using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StateDAL
    {
        public static List<State> GetStateALl()
        {
            List<State> states = null;

            using (var Context = new ContextDB())

                states = Context.States.ToList();
            return states;

        }
    }
}
