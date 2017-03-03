using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DatabaseFirst;
using Microsoft.AspNetCore.Hosting;

namespace CMD.WebAsp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            using (TasksEntities context = new TasksEntities())
            {
                TaskUser newTaskUser = new TaskUser
                {
                    UserId = Guid.NewGuid(),
                    UserName = "andrii"
                };

                context.TaskUsers.Add(newTaskUser);
                context.SaveChanges();
            }
            
            host.Run();
        }
    }
}
