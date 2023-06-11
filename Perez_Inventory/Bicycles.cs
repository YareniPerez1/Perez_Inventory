using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perez_Inventory
{
    internal class Bicycles : IShippable
    {
        public decimal shipcost { get; } = 9.50M;
        public string Product { get; } = "Bicycles";

    }
}
