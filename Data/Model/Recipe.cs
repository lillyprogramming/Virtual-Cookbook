using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Recipe
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string MealCourse { get; set; }
        public string Tags { get; set; }
        public int CookingTime { get; set; }
        public int Yield { get; set; }
        public string ImageFile { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public string Notes { get; set; }
        public string SourceOfRec { get; set; }

        //private static int nextId;
        public Recipe()
        {

        }
    }
}
