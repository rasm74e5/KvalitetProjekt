using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvalitetProjekt.Domain
{
    class Product
    {
        public string ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }

        public string MinInStock { get; set; }

    }
}
