using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class EducationalSubscription : Subscription
    {
        public override string Name => "Освітня підписка";
        public override decimal MonthlyFee => 7.99m;
        public override int MinPeriod => 6;
        public override List<string> Features => new List<string> { "30 каналів", "Доступ до освітніх матеріалів" };
    }
}
