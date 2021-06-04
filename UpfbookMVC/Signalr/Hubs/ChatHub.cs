using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace PhonebookMVC.Signalr.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string firstName, string message)
        {
            Clients.All.addNewMessageToPage(firstName,message);
        }
    }
}