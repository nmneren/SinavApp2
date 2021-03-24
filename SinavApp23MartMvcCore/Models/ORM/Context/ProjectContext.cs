using Microsoft.EntityFrameworkCore;
using SinavApp23MartMvcCore.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SinavApp23MartMvcCore.Models.ORM.Context
{
    public class ProjectContext :DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }

        public DbSet<Menus> Menus { get; set; }
        public DbSet<Content> Contents { get; set; }
    }
}
