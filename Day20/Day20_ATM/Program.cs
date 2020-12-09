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

            var atm = new ATM()
            {
                Balance = 400,
                ClientAccounts = clients
            };

            string input = string.Empty; //same as ""

            while (input != "stop")
            {
                Console.Write("Enter client id: ");
                int clientId = int.Parse(Console.ReadLine());
                Console.Write("Enter withdrawal amount: ");
                int money = int.Parse(Console.ReadLine());

                string message = atm.Withdraw(clientId, money);
                Console.WriteLine(message);

                Console.Write("Enter 'stop' to exit app: ");
                input = Console.ReadLine();
            }
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