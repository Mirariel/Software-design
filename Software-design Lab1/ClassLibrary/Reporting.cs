using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Reporting
    {
        public static void InventoryReport(Warehouse warehouse)
        {
            Console.WriteLine("Інвентаризація складу:");
            warehouse.ShowProducts();
        }
    }
}
