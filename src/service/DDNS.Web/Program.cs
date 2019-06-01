﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace DDNS.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //开始执行
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}