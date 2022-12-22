using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Identity;
using Microsoft.AspNetCore.Builder;

namespace DemoApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }).ConfigureAppConfiguration(async (hostingContext, config) =>
                {
                    config.AddEnvironmentVariables();


                    ////var credential = new DefaultAzureCredential();

                    //var credential = new ChainedTokenCredential(new DefaultAzureCredential(), new EnvironmentCredential());
                    //var token = credential
                    //.GetToken(new Azure.Core.TokenRequestContext(
                    //    new[] { "https://database.windows.net/.default" }));

                    //config.AddAzureKeyVault(keyVaultEndpoint, new DefaultAzureCredential(), token);


                    //config.AddEnvironmentVariables();
                    //var keyVaultEndpoint = new Uri(Environment.GetEnvironmentVariable("VaultUri"));
                    //var credential = new ChainedTokenCredential(new DefaultAzureCredential(), new EnvironmentCredential());
                    //config.AddAzureKeyVault(keyVaultEndpoint, credential);

                    // works
                    //config.AddEnvironmentVariables();
                    //var keyVaultEndpoint = new Uri(Environment.GetEnvironmentVariable("VaultUri"));
                    //config.AddAzureKeyVault(keyVaultEndpoint, new DefaultAzureCredential());

                    // works
                    //config.AddEnvironmentVariables();
                    //var keyVaultEndpoint = new Uri(Environment.GetEnvironmentVariable("VaultUri"));
                    //// https://learn.microsoft.com/en-us/dotnet/api/azure.identity.defaultazurecredential?view=azure-dotnet
                    //var credential = new DefaultAzureCredential();
                    //config.AddAzureKeyVault(keyVaultEndpoint, credential);

                });
    }
}
