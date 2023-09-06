using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance
{
    public class Products
    {
        public Products() 
        { 
        
        }
        public string Code { get; set; } = "";

        public string Description { get; set; } = "";

        public decimal Price { get; set; }

        public string GetDisplayedText (string sep) 
        {
            return $"{Code} {sep} {Description} {sep} {Price.ToString("c")}";
        }
    }
}
