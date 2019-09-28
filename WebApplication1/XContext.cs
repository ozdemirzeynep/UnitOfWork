using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1
{
    public class XContext:DbContext
    {
        public XContext(DbContextOptions<XContext>options): base(options)
        {

        }

        public DbSet<User> users { get; set; }
    }
}
