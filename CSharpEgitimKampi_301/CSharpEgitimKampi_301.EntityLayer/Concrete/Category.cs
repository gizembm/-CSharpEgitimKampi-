using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi_301.EntityLayer.Concrete
{
    public class Category
    {

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public bool CategoryStatues { get; set; }

        public List<Product> Products { get; set; }


    }
}
