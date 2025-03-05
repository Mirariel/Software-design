using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class DomesticSubscription : Subscription
    {
        public override string Name => "Домашня підписка";
        public override decimal MonthlyFee => 10.99m;
        public override int MinPeriod => 3;
        public override List<string> Features => new List<string> { "50 каналів", "HD якість" };
    }
}
