using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using prestasmosApi.Models;

namespace  prestasmosApi
{
    public class prestamosContext : DbContext
    {
        public prestamosContext(DbContextOptions<prestamosContext> options) : base(options)
        {            
        }

        public DbSet<equipos> equipos {get; set;}
    }
}