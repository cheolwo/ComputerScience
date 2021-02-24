using Microsoft.EntityFrameworkCore;
using NetworkModule.Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace NetworkModule.DataContext
{
    public class NetworkDataContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=Network;Integrated Security=True");

            //Data Source 
        }

        public DbSet<Node> Nodes { get; set; }
        public DbSet<Lan> Lans { get; set; }
        public DbSet<Wan> Wans { get; set; }
        public DbSet<Network> Networks { get; set; }
    }
}
