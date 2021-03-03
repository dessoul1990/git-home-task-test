using System;
using System.Collections;
using System.Linq;

namespace HomeTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = "Davis, Clyne, Fonte, Hooiveld, Shaw, Davis, Schneiderlin, Cork, Lallana, Rodriguez, Lambert";

            var players = string.Join("\n", names.Split().Select((a, b) => $"{b + 1}.{a.Trim()}"));
            Console.WriteLine(players);
            Console.WriteLine("\n");


            string namesWithDates = "Jason Puncheon, 26/06/1986; Jos Hooiveld, 22/04/1983; Kelvin Davis, 29/09/1976; Luke Shaw, 12/07/1995; Gaston Ramirez, 02/12/1990; Adam Lallana, 10/05/1988";
            IEnumerable peopleList = namesWithDates.Split(';')
                                    .Select(p => p.Trim().Split(','))
                                    .Select(p => new { FullName = p[0],
                                     BirthDate = DateTime.ParseExact(p[1].Trim(), "dd/MM/yyyy", null) })
                                    .OrderByDescending(p => p.BirthDate);


            foreach (var people in peopleList)
            {

                Console.WriteLine(people);

            }
            Console.WriteLine("\n");

            string songsLength = "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27";

            var result = songsLength
                .Split(',')
                .Select(y => y.Split(':'))
                .Aggregate((y1, y2) => new[] {
                (int.Parse(y1[0]) + int.Parse(y2[0])).ToString(),
                (int.Parse(y1[1]) + int.Parse(y2[1])).ToString()
                })
                .Aggregate((y1, y2) => $"Total length of the songs is : {int.Parse(y1) + int.Parse(y2) / 60} minutes and {int.Parse(y2) % 60} seconds");

            Console.WriteLine(result);
        }
    }
}
