using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Task2.Interface
{
    public interface ITechFactory
    {
        IDevice CreateLaptop();
        IDevice CreateNetbook();
        IDevice CreateEBook();
        IDevice CreateSmartphone();
    }

}
