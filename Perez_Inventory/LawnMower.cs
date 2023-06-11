using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perez_Inventory
{
    internal class LawnMower: IShippable
    {
        public decimal shipcost { get; } = 24.00M;
        public string Product { get; } = "Lawn Mowers";
    }
}
