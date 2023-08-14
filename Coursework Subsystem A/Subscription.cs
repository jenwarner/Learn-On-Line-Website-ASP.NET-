using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coursework_Subsystem_A
{
    public class Subscription
    {
        // this class will apply an active subscription to parent account once purchased via payment page.
        private string parentName;
        private int activeSubscription;

        public string ParentName
        {
            get { return parentName; }
            set { parentName = value; }
        }

        public int ActiveSubscription
        {
            get { return activeSubscription; }
            set { activeSubscription = value; }
        }
        // get parent name/id from session and access database to store new membership details.
    }
}