using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Restaraunt
    {
        List<Table> Tables { get; set; } = new List<Table>()
        {
            new Table(){TBName = 7},
            new Table(){TBName = 15},
            new Table(){TBName = 2}
        };
        List<Food> FoodsInfo { get; set; } = new List<Food>()
        {
            new Food() {Name = "Pizza", Price = 14.5, ID = 1},
            new Food() {Name = "Spaghetti", Price = 9.25, ID = 2},
            new Food() {Name = "BBQ Ribs ", Price = 20, ID = 3},
            new Food() {Name = "Fries", Price = 5, ID = 4}
        };
    }
}
