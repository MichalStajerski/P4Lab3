using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Kontekst();
            db.Database.EnsureCreated();
            db.Zajecias.Add(new Zajecia() { Nazwa = "p4", GodzinaRozpoczecia = new DateTime(2020, 1, 1, 12, 30, 0) }); //nie mozna wstawiac wlasnego id
            db.SaveChanges();

            var zajecia = db.Zajecias.Where(x => x.Id > 2);

            foreach (var item in zajecia)
            {
                Console.WriteLine($"{item.Id}. {item.Nazwa} {item.GodzinaRozpoczecia.ToShortTimeString()}");
            }

            var zajeciaDoZmiany = db.Zajecias.First(x => x.Nazwa.StartsWith("p"));
            zajeciaDoZmiany.Nazwa = "Am2";
            db.Update(zajeciaDoZmiany);
            db.SaveChanges();



            using (var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                var nxwc = new Northwind();
                 

                foreach (var order in nxwc.Orders.Include(x => x.Customer))
                {
                    Console.WriteLine(order.Customer.CompanyName);
                }


                foreach (var item in nxwc.Orders
                    .Include(x => x.CenaJednostkowa)
                    .Include(x => x.IdZamowienia))
                {

                }
               
            }


            


           

          


            } 
            
           

            

           


        }
    }
}