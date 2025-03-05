using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class PremiumSubscription : Subscription
    {
        public override string Name => "Преміум підписка";
        public override decimal MonthlyFee => 19.99m;
        public override int MinPeriod => 1;
        public override List<string> Features => new List<string> { "100+ каналів", "4K UHD", "Без реклами" };
    }
}
