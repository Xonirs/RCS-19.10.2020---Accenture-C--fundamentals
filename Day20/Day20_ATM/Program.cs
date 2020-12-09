using System;
using System.Collections.Generic;

namespace Day20_ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ClientAccount> clients = new List<ClientAccount>();
            clients.Add(new ClientAccount() { ClientId = 1, AvailableMoney = 100 });
            clients.Add(new ClientAccount() { ClientId = 2, AvailableMoney = 200 });
            clients.Add(new ClientAccount() { ClientId = 3, AvailableMoney = 300 });
            clients.Add(new ClientAccount() { ClientId = 4, AvailableMoney = 50 });

            
        }
    }
}

/*
//the 3rd client
var clientNr3 = clients[2];
//the 3rd client's client id
var clientIdNr3 = clientNr3.ClientId;
var clientIdNr3_2 = clients[2].ClientId; 
 */