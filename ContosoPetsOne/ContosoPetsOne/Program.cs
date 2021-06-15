using ContosoPetsOne.Data;
using ContosoPetsOne.Models;
using System.Linq;
using static System.Console;
using Microsoft.EntityFrameworkCore;


namespace ContosoPetsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            using ContosoPetsOneContext context = new ContosoPetsOneContext();

            var noviArtikal = context.Products
                                .Where(p => p.Name == "Sareni Artikal")
                                .FirstOrDefault();

            var products = context.Products
                .Where(p => p.Price >= 5.00m)
                .OrderBy(p => p.Name);



            foreach (Product p in products)
            {
                WriteLine($"Id:      {p.Id} ");
                WriteLine($"Name:    {p.Name} ");
                WriteLine($"Price:   {p.Price} ");
                WriteLine(new string('-', 20));
            }

           

        }
    }
}
