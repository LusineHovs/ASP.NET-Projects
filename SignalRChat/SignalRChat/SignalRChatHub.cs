using Microsoft.AspNet.SignalR;
using System;

namespace SignalRChat
{
    public class SignalRChatHub : Hub
    {
        public void BroadCastMessage(string msgFrom, string msg)
        {
            Clients.All.receiveMessage(msgFrom, msg);
        }
    }
}