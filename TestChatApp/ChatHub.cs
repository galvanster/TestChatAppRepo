using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace TestChatApp
{
    [HubName("chat")]
    public class ChatHub : Hub
    {
        public void SendMessage(SendData data)
        {
            Clients.All.newMessage(data.name + ": " + data.message);
        }
    }

    public class SendData
    {   
       public string message { get; set; }
       public string name { get; set; }
    }
}