using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Helper
    {
        public static bool  CheckBlogTitle(string title)
        {
            if (title.Length >= 5)
            {
               
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckBlogDescription(string description)
        {
            if (description.Length >= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
