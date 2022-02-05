﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace ConsoleToWebAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
        
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(app => {

                app.UseStartup<Startup>();
                
                });
        
    }
}
