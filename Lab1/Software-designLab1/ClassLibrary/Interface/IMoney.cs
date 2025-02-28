using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interface
{
    public interface IMoney
    {
        int WholePart { get; set; }
        int Cents { get; set; }
        void Display();
    }
}
