using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Repository
    {
        
        public static BlogPost GetBloPotsByID(int ID)
        {
           BlogPost Result = null;
            using (var Context = new BlogPostContext())
            {
                Result = Context.BlogPosts.FirstOrDefault(
                    p => p.Id == ID
                    );

            }
            return Result;
        }

        public static void GuardarPost(BlogPost blogPost)
        {
            try
            {
                using (var Context = new BlogPostContext())
                {
                    Context.BlogPosts.Add(blogPost);
                    Context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
