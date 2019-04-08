using Microsoft.Extensions.Configuration;
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            var connectionString = config.GetConnectionString("nombre_db");

            Console.WriteLine($"{ connectionString }");

            Console.ReadKey();
        }
    }
}
