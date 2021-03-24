using SinavApp23MartMvcCore.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavApp23MartMvcCore.Models.ModelVM
{
    public class ListVM
    {
        public List<Menus> Menu { get; set; }
        public List<Content> ContentList { get; set; }
    }
}
