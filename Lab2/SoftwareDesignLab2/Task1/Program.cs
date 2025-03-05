using ClassLibrary;
using ClassLibrary.Interface;
class Program
{
    static void Main()
    {
        ISubscriptionFactory website = new WebSite();
        ISubscriptionFactory mobileApp = new MobileApp();
        ISubscriptionFactory managerCall = new ManagerCall();

        ISubscription sub1 = website.CreateSubscription();
        ISubscription sub2 = mobileApp.CreateSubscription();
        ISubscription sub3 = managerCall.CreateSubscription();

        sub1.ShowInfo();
        Console.WriteLine();
        sub2.ShowInfo();
        Console.WriteLine();
        sub3.ShowInfo();
    }
}