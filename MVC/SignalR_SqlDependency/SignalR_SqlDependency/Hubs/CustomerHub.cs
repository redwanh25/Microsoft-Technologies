using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR_SqlDependency.Hubs
{
    public class CustomerHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
        public static void Show()
        {
            IHubContext hubContext = GlobalHost.ConnectionManager.GetHubContext<CustomerHub>();
            hubContext.Clients.All.displayCustomer();
        }
    }
}