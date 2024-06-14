using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApp16.Entities;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment(Console.ReadLine());
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'am going to visit this wonderful country",
                12
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Console.WriteLine(p1);
        }
    }
}
