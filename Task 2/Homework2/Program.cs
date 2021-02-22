using System;


namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new LinkedList<string>();
            cities.Add("Sydney");
            cities.Add("Barcelona");
            cities.Add("New York");
            cities.Add("Tokyo");
            cities.Add("Kyiv");
            cities.Add("Paris");
            cities.Add("Warsaw");
            cities.Add("Madrid");
            cities.Add("Rome");
            

            foreach (var city in cities)
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();


           cities.Delete("Paris");
           cities.Delete("Rome");
            foreach (var city in cities)
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        
    }
}
