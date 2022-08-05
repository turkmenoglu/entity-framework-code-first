using EFCodeFirst.Model.Context;
using System;
using System.Linq;

namespace EFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("started...");

            var ornekVeriDbContext = new OrnekVeriDbContext();
            //ornekVeriDbContext.Database.Delete();
            //ornekVeriDbContext.Database.Create();

            //ornekVeriDbContext.OrnekTablos.Add(new OrnekTablo
            //{
            //    Kolon1 = "Örnek veri1 kolon1",
            //    Kolon2 = "Örnek veri1 kolon2"
            //});
            //ornekVeriDbContext.OrnekTablos.Add(new OrnekTablo
            //{
            //    Kolon1 = "Örnek veri2 kolon1",
            //    Kolon2 = "Örnek veri2 kolon2"
            //});
            //ornekVeriDbContext.OrnekTablos.Add(new OrnekTablo
            //{
            //    Kolon1 = "Örnek veri3 kolon1",
            //    Kolon2 = "Örnek veri3 kolon2"
            //});
            //ornekVeriDbContext.SaveChanges();

            //var ornekTablo = ornekVeriDbContext.OrnekTablos.FirstOrDefault(o => o.Id == 2);
            //ornekTablo.Kolon1 = "Örnek veri2 kolon1 güncel";
            //ornekTablo.Kolon2 = "Örnek veri2 kolon2 güncel";
            //ornekVeriDbContext.SaveChanges();

            //var ornekTablo = ornekVeriDbContext.OrnekTablos.FirstOrDefault(o => o.Id == 1);
            //ornekVeriDbContext.OrnekTablos.Remove(ornekTablo);
            //ornekVeriDbContext.SaveChanges();

            foreach (var item in ornekVeriDbContext.OrnekTablos)
            {
                Console.WriteLine($"{item.Id} {item.Kolon1} {item.Kolon2}");
            }

            Console.WriteLine("done...");
            Console.Read();
        }
    }
}