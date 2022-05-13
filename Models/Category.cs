using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Pie> Pies { get; set; }

        //public Category(int id, string name, string description)
        //{
        //    CategoryId = id;
        //    CategoryName = name;
        //    Description = description;
        //}
    }

    
}
