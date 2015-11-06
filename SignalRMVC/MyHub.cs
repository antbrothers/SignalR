using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRMVC
{
    [HubName("char")]
    public class MyHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
        public void Send(string clientName, string message)
        {
            Clients.All.addSomeMessage(clientName, message);
        }

    }
}