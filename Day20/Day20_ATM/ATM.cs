using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day20_ATM
{
    class ATM
    {
        //how much money is left in the ATM
        public int Balance;
        //ATM knows all the client accounts
        public List<ClientAccount> ClientAccounts = new List<ClientAccount>();

        /// <summary>
        /// Withdraw method will take clientId and try to find the Client.
        /// If the client is found then method will attempt to withdraw money.
        /// Beforehand checking if the atm/client balance allows it.
        /// </summary>
        /// <param name="clientId">The Id of the ClientAccount</param>
        /// <param name="withdrawAmount">Amount of money to withdraw</param>
        /// <returns>Message about successful OR failed withdrawal process</returns>
        public string Withdraw(int clientId, int withdrawAmount)
        {
            //finding the user/client
            #region finding client without LINQ
            //Creating a variable for the client
            //ClientAccount client = null; //default value, we don't know if client exists
            //for (int i = 0; i < ClientAccounts.Count; i++)
            //{
            //    if (ClientAccounts[i].ClientId == clientId)
            //    {
            //        client = ClientAccounts[i];
            //        break; //exit the loop if the client is found
            //    }
            //}
            #endregion

            #region finding client with LINQ
            ClientAccount client = ClientAccounts.FirstOrDefault(c => c.ClientId == clientId);
            #endregion

            //client id validation
            //if variable client is equal to null, it was not found given the clientId
            if (client == null) 
            {
                return $"Such client with client id '{clientId}' does not exist!";
            }

            //check if there is enough money in account
            if (client.AvailableMoney < withdrawAmount)
            {
                return $"There is not enough money in the client account!";
            }

            //check if there is enough money in the atm
            if (Balance < withdrawAmount)
            {
                return $"There is not enough money in the ATM!";
            }

            //withdraw the money
            Balance -= withdrawAmount;
            client.AvailableMoney -= withdrawAmount;

            return $"Here you go, take your {withdrawAmount} EUR!";
        }
    }
}
