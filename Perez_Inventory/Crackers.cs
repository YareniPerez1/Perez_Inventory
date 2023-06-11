using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perez_Inventory
{
    internal class Crackers : IShippable
    {
        private decimal _counter = 0;
       public decimal shipcost { get; } = 0.57M;
        public string Product { get; } = "Crackers";

        



    }
}
