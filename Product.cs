using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGU.C986
{
    class Product
    {
        public BindingList AssociatedParts<Part>;
        private int ProductID;
        private string Name;
        private decimal Price;
        private int InStock;
        private int Min;
        private int Max;
    }
}
