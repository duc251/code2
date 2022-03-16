using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class ProductInCategory
    {
        public int ProductId { get; set; }

        public CtrHopDong? CtrHopDong { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
