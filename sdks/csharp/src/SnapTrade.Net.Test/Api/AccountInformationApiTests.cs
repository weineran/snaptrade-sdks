/*
 * SnapTrade
 *
 * Connect brokerage accounts to your app for live positions and trading
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: api@snaptrade.com
 * Generated by: https://konfigthis.com
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using SnapTrade.Net.Client;
using SnapTrade.Net.Api;
using SnapTrade.Net.Model;

namespace SnapTrade.Net.Test.Api
{
    /// <summary>
    ///  Class for testing AccountInformationApi
    /// </summary>
    public class AccountInformationApiTests : IDisposable
    {
        private Snaptrade client;

        public AccountInformationApiTests()
        {
            client = new Snaptrade();
            client.SetBasePath("http://127.0.0.1:4010");
            // Configure custom BasePath if desired
            // client.SetBasePath("https://api.snaptrade.com/api/v1");
            client.SetClientId(System.Environment.GetEnvironmentVariable("SNAPTRADE_CLIENT_ID"));
            client.SetConsumerKey(System.Environment.GetEnvironmentVariable("SNAPTRADE_CONSUMER_KEY"));

        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test GetAllUserHoldings
        /// </summary>
        [Fact]
        public void GetAllUserHoldingsTest()
        {
            var userId = "userId_example";
            var userSecret = "userSecret_example";
            var brokerageAuthorizations = "917c8734-8470-4a3e-a18f-57c3f2ee6631"; // Optional. Comma seperated list of authorization IDs (only use if filtering is needed on one or more authorizations). (optional) 
            
            try
            {
                // List all accounts for the user, plus balances, positions, and orders for each account.
                List<AccountHoldings> result = client.AccountInformation.GetAllUserHoldings(userId, userSecret, brokerageAuthorizations);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AccountInformationApi.GetAllUserHoldings: " + e.Message);
                Console.WriteLine("Status Code: "+ e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            catch (ClientException e)
            {
                Console.WriteLine(e.Response.StatusCode);
                Console.WriteLine(e.Response.RawContent);
                Console.WriteLine(e.InnerException);
            }
        }

        /// <summary>
        /// Test GetUserAccountBalance
        /// </summary>
        [Fact]
        public void GetUserAccountBalanceTest()
        {
            var userId = "userId_example";
            var userSecret = "userSecret_example";
            var accountId = "917c8734-8470-4a3e-a18f-57c3f2ee6631"; // The ID of the account to get balances.
            
            try
            {
                // List account balances
                List<Balance> result = client.AccountInformation.GetUserAccountBalance(userId, userSecret, accountId);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AccountInformationApi.GetUserAccountBalance: " + e.Message);
                Console.WriteLine("Status Code: "+ e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            catch (ClientException e)
            {
                Console.WriteLine(e.Response.StatusCode);
                Console.WriteLine(e.Response.RawContent);
                Console.WriteLine(e.InnerException);
            }
        }

        /// <summary>
        /// Test GetUserAccountDetails
        /// </summary>
        [Fact]
        public void GetUserAccountDetailsTest()
        {
            var userId = "userId_example";
            var userSecret = "userSecret_example";
            var accountId = "917c8734-8470-4a3e-a18f-57c3f2ee6631"; // The ID of the account to get detail of.
            
            try
            {
                // Return details of a specific investment account
                Account result = client.AccountInformation.GetUserAccountDetails(userId, userSecret, accountId);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AccountInformationApi.GetUserAccountDetails: " + e.Message);
                Console.WriteLine("Status Code: "+ e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            catch (ClientException e)
            {
                Console.WriteLine(e.Response.StatusCode);
                Console.WriteLine(e.Response.RawContent);
                Console.WriteLine(e.InnerException);
            }
        }

        /// <summary>
        /// Test GetUserAccountOrders
        /// </summary>
        [Fact]
        public void GetUserAccountOrdersTest()
        {
            var userId = "userId_example";
            var userSecret = "userSecret_example";
            var accountId = "917c8734-8470-4a3e-a18f-57c3f2ee6631"; // The ID of the account to get orders.
            var state = "all"; // defaults value is set to \"all\" (optional) 
            var days = 30; // Number of days in the past to fetch the most recent orders. Defaults to the last 30 days if no value is passed in. (optional) 
            
            try
            {
                // List account orders
                List<AccountOrderRecord> result = client.AccountInformation.GetUserAccountOrders(userId, userSecret, accountId, state, days);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AccountInformationApi.GetUserAccountOrders: " + e.Message);
                Console.WriteLine("Status Code: "+ e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            catch (ClientException e)
            {
                Console.WriteLine(e.Response.StatusCode);
                Console.WriteLine(e.Response.RawContent);
                Console.WriteLine(e.InnerException);
            }
        }

        /// <summary>
        /// Test GetUserAccountPositions
        /// </summary>
        [Fact]
        public void GetUserAccountPositionsTest()
        {
            var userId = "userId_example";
            var userSecret = "userSecret_example";
            var accountId = "917c8734-8470-4a3e-a18f-57c3f2ee6631"; // The ID of the account to get positions.
            
            try
            {
                // List account positions
                List<Position> result = client.AccountInformation.GetUserAccountPositions(userId, userSecret, accountId);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AccountInformationApi.GetUserAccountPositions: " + e.Message);
                Console.WriteLine("Status Code: "+ e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            catch (ClientException e)
            {
                Console.WriteLine(e.Response.StatusCode);
                Console.WriteLine(e.Response.RawContent);
                Console.WriteLine(e.InnerException);
            }
        }

        /// <summary>
        /// Test GetUserHoldings
        /// </summary>
        [Fact]
        public void GetUserHoldingsTest()
        {
            var accountId = "917c8734-8470-4a3e-a18f-57c3f2ee6631"; // The ID of the account to fetch holdings for.
            var userId = "userId_example";
            var userSecret = "userSecret_example";
            
            try
            {
                // List balances, positions and orders for the specified account
                AccountHoldingsAccount result = client.AccountInformation.GetUserHoldings(accountId, userId, userSecret);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AccountInformationApi.GetUserHoldings: " + e.Message);
                Console.WriteLine("Status Code: "+ e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            catch (ClientException e)
            {
                Console.WriteLine(e.Response.StatusCode);
                Console.WriteLine(e.Response.RawContent);
                Console.WriteLine(e.InnerException);
            }
        }

        /// <summary>
        /// Test ListUserAccounts
        /// </summary>
        [Fact]
        public void ListUserAccountsTest()
        {
            var userId = "userId_example";
            var userSecret = "userSecret_example";
            
            try
            {
                // List accounts
                List<Account> result = client.AccountInformation.ListUserAccounts(userId, userSecret);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AccountInformationApi.ListUserAccounts: " + e.Message);
                Console.WriteLine("Status Code: "+ e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            catch (ClientException e)
            {
                Console.WriteLine(e.Response.StatusCode);
                Console.WriteLine(e.Response.RawContent);
                Console.WriteLine(e.InnerException);
            }
        }

        /// <summary>
        /// Test UpdateUserAccount
        /// </summary>
        [Fact]
        public void UpdateUserAccountTest()
        {
            var userId = "userId_example";
            var userSecret = "userSecret_example";
            var accountId = "accountId_example"; // The ID of the account to update.
            
            try
            {
                // Update details of an investment account
                List<Account> result = client.AccountInformation.UpdateUserAccount(userId, userSecret, accountId);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AccountInformationApi.UpdateUserAccount: " + e.Message);
                Console.WriteLine("Status Code: "+ e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            catch (ClientException e)
            {
                Console.WriteLine(e.Response.StatusCode);
                Console.WriteLine(e.Response.RawContent);
                Console.WriteLine(e.InnerException);
            }
        }
    }
}
