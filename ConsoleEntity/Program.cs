using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MusicStoreDBContext())
            {
                var albums = context.Albums;
                Album a1 = new Album
                {
                    Title = "Album2",
                    Price = 20
                };
                context.Albums.Add(a1);
                //context.SaveChanges();

                Console.WriteLine(albums.Count());

                Console.WriteLine(context.Albums.Where(x => x.Title == "Album1").Count());
                Console.ReadKey();
            }
        }
    }
}
