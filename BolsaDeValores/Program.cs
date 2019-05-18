using System.Linq;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using BolsaDeValores.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using BolsaDeValores.Controllers;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.DependencyInjection;

namespace BolsaDeValores
{
    public class Program
    {        
        public static int currentId = 2002;
        public static Clients currentClient { get; set; }       

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();  
            //Usuario u = new Usuario();            
            //Task.Run(async () =>
            //{   
            //    currentClient = await u.SelectClient(currentId);
            //}).GetAwaiter().GetResult();        
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();        
    }

    public class Usuario : Controller
    {
        public static bool currentIdAdmin;
        public readonly BolsaDeValoresContext _context;

        public Usuario(BolsaDeValoresContext context)
        {
            _context = context;
        }

        public async Task<Clients> SelectClient(int id)
        {          
            Clients client = await _context.Clients.FirstOrDefaultAsync(i => i.Id == id);
            return client;          
        }
    }
}
