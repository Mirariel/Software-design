using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interface
{
    public interface IProduct
    {
        string Name { get; set; }
        IMoney Price { get; set; }
        string Category { get; set; }
        void DecreasePrice(int amount);
    }
}
