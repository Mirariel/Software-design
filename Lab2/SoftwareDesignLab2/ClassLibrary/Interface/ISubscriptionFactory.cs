﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interface
{
   public interface ISubscriptionFactory
    {
        ISubscription CreateSubscription();
    }
}
