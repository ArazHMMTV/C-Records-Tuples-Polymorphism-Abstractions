using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Comment
    {
        public int Id { get; set; }
        private int _id;
        public string Content { get; set; }

        public Comment(string content)
        {
            _id++;
            Id = _id;
            Content = content;
        }

        public  virtual string  ToString()
        {
            return($"Id:{Id} Content:{Content}");
        }
    }
}
