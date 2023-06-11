using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perez_Inventory
{
    internal class BaseballGloves: IShippable
    {
        public decimal shipcost { get; } = 3.23M;
        public string Product { get; } = "Baseball Gloves";
    }
}
