using DemoDataModel.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebAPI.Hubs
{
    public class RideHub : Hub
    {
        public void SendToDrivers(string orderJson)
        {
            // Use serializer to map json string to Order class       
            Clients.Group("Drivers").addMessage("Put message here");
        }

        public void InformClient(string Message)
        {
            Clients.Group("Drivers").addMessage("Put message here");
        }

        public void SubscribeUser()
        {
            Groups.Add(Context.ConnectionId, "User");
        }

        public void SubscribeDriver()
        {
            Groups.Add(Context.ConnectionId, "Drivers");
        }

        public void UnsubscribeUser()
        {
            Groups.Remove(Context.ConnectionId, "Users");
        }

        public void UnsubscribeDriver()
        {
            Groups.Remove(Context.ConnectionId, "Drivers");
        }
    }
}