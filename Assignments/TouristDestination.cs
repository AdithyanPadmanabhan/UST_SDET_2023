using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TouristDestination
    {
        public TouristDestination(string? name, string? country, double rating, int pricePerNight)
        {
            Name = name;
            Country = country;
            Rating = rating;
            PricePerNight = pricePerNight;
        }

        public string? Name { get; set; }
        public string? Country { get; set; }
        public double Rating { get; set; }
        public int PricePerNight { get; set; }

       
        public static void TouristDest()
        {
            List<TouristDestination> touristDestinationsList = new List<TouristDestination>();
            touristDestinationsList.Add(new TouristDestination("TajMahal", "India", 4.5, 3000));
            touristDestinationsList.Add(new TouristDestination("Cape Bridge", "cape Town", 2.5, 10000));
            touristDestinationsList.Add(new TouristDestination("Paris Tower", "Paris", 5, 40000));
            touristDestinationsList.Add(new TouristDestination("Burj khalifa", "Dubai", 3.5, 50000));

            var tourist = touristDestinationsList.FindAll(s => s.Rating >= 3.5);

            Console.WriteLine("Top rated Tourist Place:\n ");
            foreach (var item in tourist)
            {
                Console.WriteLine(item.Name + " " + item.Country + " " + item.Rating +" "+ item.PricePerNight);
            }
            Console.WriteLine(" ");

            Console.WriteLine("Sorting Tourist Place according to Price:\n ");
            var sort = touristDestinationsList.OrderBy(s => s.PricePerNight);
            foreach (var item in sort)
            {
                Console.WriteLine(item.Name + " " + item.Country + " " + item.Rating + " " + item.PricePerNight);
            }
            Console.WriteLine(" ");

            Console.WriteLine("Tourist destination in India:\n ");
            var loc = touristDestinationsList.Where(s => s.Country.Equals("India"));
            foreach (var item in loc)
            {
                Console.WriteLine(item.Name + " " + item.Country + " " + item.Rating + " " + item.PricePerNight);
            }


        }
    }
}
