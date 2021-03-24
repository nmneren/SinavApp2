using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavApp23MartMvcCore.Models.ORM.Entity
{
    public class Content
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
