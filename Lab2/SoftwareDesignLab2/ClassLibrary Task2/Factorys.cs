using ClassLibrary_Task2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Task2
{
    public class IProneFactory : ITechFactory
    {
        public IDevice CreateLaptop() => new Laptop();
        public IDevice CreateNetbook() => new Netbook();
        public IDevice CreateEBook() => new EBook();
        public IDevice CreateSmartphone() => new Smartphone();
    }

   public class KiaomiFactory : ITechFactory
    {
        public IDevice CreateLaptop() => new Laptop();
        public IDevice CreateNetbook() => new Netbook();
        public IDevice CreateEBook() => new EBook();
        public IDevice CreateSmartphone() => new Smartphone();
    }

    public class BalaxyFactory : ITechFactory
    {
        public IDevice CreateLaptop() => new Laptop();
        public IDevice CreateNetbook() => new Netbook();
        public IDevice CreateEBook() => new EBook();
        public IDevice CreateSmartphone() => new Smartphone();
    }
}
