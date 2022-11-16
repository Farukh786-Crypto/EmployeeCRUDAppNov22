using CRUDAppServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppServer.DAL
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
