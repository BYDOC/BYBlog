using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYBlog.Entity.Concrete
{
    public class Subscriber
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }

    }
}
