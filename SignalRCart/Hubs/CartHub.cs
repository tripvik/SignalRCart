using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRCart
{
    public class CartHub : Hub
    {
        public void Send(int count, string user)
        {
            Clients.All.UpdateCartCount(count, user);
        }
    }
}