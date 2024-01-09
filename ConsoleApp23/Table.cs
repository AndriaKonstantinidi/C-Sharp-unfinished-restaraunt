using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Table
    {
        public int TBName { get; set; }
        List<Table> Orders { get; set; } = new List<Table>() { };
    }
}
