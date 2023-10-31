using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class HotelEvent
    {
        public string? EventName { get; set; }
        public DateOnly EventDate {  get; set; }
        public string? Location {  get; set; }
        public int Capacity {  get; set; }
        public static List<HotelEvent> hotelEvent = new List<HotelEvent>();

        public HotelEvent(string? eventName, DateOnly eventDate, string? location, int capacity)
        {
            EventName = eventName;
            EventDate = eventDate;
            Location = location;
            Capacity = capacity;
        }

        public static void AddEvent(HotelEvent hotelevent)
        {
            hotelEvent.Add(hotelevent);
            Console.WriteLine("AddedEvent");
        }
        public static void RegisterEvent()
        {
            foreach (var hotel in hotelEvent)
            {
                if ((hotel.EventDate).ToString() == DateTime.Today.ToShortDateString())
                {
                    Console.WriteLine("Event is today");
                }
            }
        }
        public static void Statusreg()
        {
            foreach (var hotel in hotelEvent)
            {
                if ((hotel.EventDate).ToString() != DateTime.Today.ToShortDateString())
                {
                    Console.WriteLine("Event date is: {0}", hotel.EventDate);
                }
            }
        }
    }
}

