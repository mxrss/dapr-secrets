// See https://aka.ms/new-console-template for more information
using System;
using Dapr.Client;

namespace Demo
{
    public class CLI
    {

        public static void Main(string[] args) {
            var daprClient = new DaprClientBuilder().Build();
            var val = daprClient.GetBulkSecretAsync("local-secret-store");
            while (true)
            {

                Console.WriteLine("Value from method: " + val.Result);
                System.Threading.Thread.Sleep(1000);
                
            }
        }

    }

    }


