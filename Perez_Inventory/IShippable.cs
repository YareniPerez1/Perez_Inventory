using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perez_Inventory
{
    internal interface IShippable
    {
        decimal shipcost { get; }

         string Product { get; }

       

         //string 
         //does shipper also need to inheret from ishippable??
    }
}
