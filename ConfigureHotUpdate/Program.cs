using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace ConfigureHotUpdate
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var configurationRoot = builder.Build();

            ChangeToken.OnChange(() => configurationRoot.GetReloadToken(), () =>
            {
                Console.WriteLine($"Key1: {configurationRoot["Key1"]}");
            });

            //IChangeToken token = configurationRoot.GetReloadToken();

            //token.RegisterChangeCallback(state =>
            //{
            //}, configurationRoot);
            Console.ReadKey();
        }
    }
}