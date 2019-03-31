using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryBot
{
    internal interface IBlackHoleItem
    {
        string Name { get; set; }
        int Id { get; set; }

        string ToString();
    }
}
