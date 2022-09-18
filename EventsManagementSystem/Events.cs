using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsManagementSystem
{
    public class Events
    {
        // Create private attributes
        private int id;
        private string startDate;
        private string endDate;
        private string location;
        private int capacity;
        private int cost;

        // Public properties to access private variables 
        public int ID { get => id; set => id = value; }
        public string StartDate { get => startDate; set => startDate = value; } 
        public string EndDate { get => endDate; set => endDate = value; }
        public string Location { get => location; set => location = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int Cost { get => cost; set => cost = value; }

        // Constructor without any parameters
        public Events()
        {
            id = 0;
            startDate = "Not set";
            endDate = "Not set";
            location = "Not set";
            capacity = 0;
            cost = 0;
        }

        // Constructor with 6 parameters both string and int
        public Events(int pID, string pStartDate, string pEndDate, string pLocation, int pCapacity, int pCost)
        {
            id = pID;
            startDate = pStartDate;
            endDate = pEndDate;
            location = pLocation;
            capacity = pCapacity;
            cost = pCost;
        }

        //ToString Method
        public override string ToString()
        {
            return ID + "       " + StartDate + "     " + EndDate
                + "      " + Location + "          " + Capacity
                + "                   " + Cost;
        }
    }
}
