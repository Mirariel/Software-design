using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_Task2.Interface;

namespace ClassLibrary_Task2
{
    public class Laptop : IDevice
    {
        public string GetDeviceType() => "Laptop";
    }

    public class Netbook : IDevice
    {
        public string GetDeviceType() => "Netbook";
    }

    public class EBook : IDevice
    {
        public string GetDeviceType() => "E-Book";
    }

    public class Smartphone : IDevice
    {
        public string GetDeviceType() => "Smartphone";
    }
}
