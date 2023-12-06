using Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class RecipeContext : DbContext
    {
        public RecipeContext()
            : base("name=RecipeContext")
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
    }
}
