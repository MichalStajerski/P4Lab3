using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Lab3
{
    //naszym kontesktem bedzie polaczenie z baza danych
    class Kontekst : DbContext
    {
        public DbSet<Zajecia> Zajecias { get; set; } //zbior z bazy

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");//connection string

        }
        /* protected override void OnModelCreating(ModelBuilder modelBuilder) // drugie podejscie fluent zamiast adnotacji
             //wybieramy jedno, wzajemnie mogo sia wykluczac
         {
             modelBuilder
                    .Entity<Zajecia>()
                    .Property(x => x.Nazwa)
                    .HasMaxLength(255)
                    .IsRequired()
                    .HasColumnName("NazwaFluent");



         }
         */

    }
}