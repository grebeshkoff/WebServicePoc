﻿using System.IO;

using Microsoft.AspNetCore.Hosting;

namespace WebServicePoc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebHost host =
                new WebHostBuilder().UseKestrel()
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .UseIISIntegration()
                    .UseStartup<Startup>()
                    .Build();

            host.Run();
        }
    }
}