﻿using System;
using System.Text.Json;
using System.Threading.Tasks;
using MyJetWallet.Circle;

namespace TestApp
{
    static class Program
    {
        private static string _accessToken;
        private static ICircleClient _client;

        static async Task Main(string[] args)
        {
            _accessToken = Environment.GetEnvironmentVariable("CircleAccessToken");

            if (string.IsNullOrEmpty(_accessToken))
            {
                Console.WriteLine("AccessToken is empty. Please setup env variable");
                return;
            }

            _client = new CircleClient(_accessToken);

            // await TestPublicKey();
            //await TestCards();
            await TestBankAccounts();
        }

        private static async Task TestPublicKey()
        {
            var key = await _client.GetPublicKeyAsync();
            Console.WriteLine(JsonSerializer.Serialize(key, new JsonSerializerOptions()
            {
                WriteIndented = true
            }));
        }

        private static async Task TestCards()
        {
            var cards = await _client.GetListOfCardsAsync();
            Console.WriteLine(JsonSerializer.Serialize(cards, new JsonSerializerOptions()
            {
                WriteIndented = true
            }));

            //var card = await _client.GetCardAsync("1");
            //Console.WriteLine(JsonSerializer.Serialize(card, new JsonSerializerOptions()
            //{
            //    WriteIndented = true
            //}));
        }

        private static async Task TestBankAccounts()
        {
            //EXAMPLE FROM CIRCLE
            var bank1 = await _client.CreateBankAccountUsSwiftAsync(
                "6ae62bf2-bd71-49ce-a599-165ffcc33680",
                "123456789",
                "021000021",
                new MyJetWallet.Circle.Models.WireTransfers.BillingDetails
                {
                    City = "Boston",
                    Country = "US",
                    District = "MA",
                    Line1 = "1 Main Street",
                    Name = "John Smith",
                    PostalCode = "02201",
                },
                new MyJetWallet.Circle.Models.WireTransfers.BankAddress
                {
                    Country = "US",
                });

            Console.WriteLine(JsonSerializer.Serialize(bank1, new JsonSerializerOptions()
            {
                WriteIndented = true
            }));
        }
    }
}