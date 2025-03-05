using ClassLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    abstract class Subscription : ISubscription
    {
        public abstract string Name { get; }
        public abstract decimal MonthlyFee { get; }
        public abstract int MinPeriod { get; }
        public abstract List<string> Features { get; }

        public void ShowInfo()
        {
            Console.WriteLine($"Підписка: {Name}\nЩомісячна плата: {MonthlyFee}$\nМінімальний період: {MinPeriod} місяців\nМожливості:");
            Features.ForEach(f => Console.WriteLine("- " + f));
        }
    }
}
