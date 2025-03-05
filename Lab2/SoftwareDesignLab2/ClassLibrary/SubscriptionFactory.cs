using ClassLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class SubscriptionFactory : ISubscriptionFactory
    {
        public abstract ISubscription CreateSubscription();
    }

    public class WebSite : SubscriptionFactory
    {
        public override ISubscription CreateSubscription() => new DomesticSubscription();
    }

    public class MobileApp : SubscriptionFactory
    {
        public override ISubscription CreateSubscription() => new EducationalSubscription();
    }

    public class ManagerCall : SubscriptionFactory
    {
        public override ISubscription CreateSubscription() => new PremiumSubscription();
    }

}
