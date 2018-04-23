using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLogPostBL
    {
        public static BlogPost GetByID(int ID)
        {
            return DAL.Repository.GetBloPotsByID(ID);
        }

        public static void GuardarBlogPost(BlogPost blogPost)
        {
            DAL.Repository.GuardarPost(blogPost);
        }
    }
}
