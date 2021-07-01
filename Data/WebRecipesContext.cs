using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebRecipes.Models;

namespace WebRecipes.Data
{
    public class WebRecipesContext : DbContext
    {
        public WebRecipesContext (DbContextOptions<WebRecipesContext> options)
            : base(options)
        {
        }

        public DbSet<WebRecipes.Models.Recipe> Recipe { get; set; }
    }
}
