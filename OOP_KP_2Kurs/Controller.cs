using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_KP_2Kurs
{
    public class Controller
    {
        public List<RailwayTransport> _railwayTransports = new List<RailwayTransport>();
        public List<RiverTram> _riverTrams = new List<RiverTram>();
        public List<Bus> _buses = new List<Bus>();

        public Controller()
        {
            ReadBusFromFile();
            ReadRiverTramFromFile();
            ReadRailwayTransportFromFile();
        }
        void ReadBusFromFile()
        {
            var file = File.ReadAllLines("../../Transport/buses.txt");
            foreach(var fileLine in file)
            {
                string[] decemitional_0 = { " ", "  ", "\t" };
                string[] fileElement = fileLine.Split(decemitional_0,
                    StringSplitOptions.RemoveEmptyEntries);
                List<string> route = new List<string>();
                for(int i=2;i<fileElement.Length;i++)
                {
                    route.Add(fileElement[i]);
                }
                _buses.Add(new Bus(fileElement[0], int.Parse(fileElement[1]), route));
            }
        }

        void ReadRailwayTransportFromFile()
        {
            var file = File.ReadAllLines("../../Transport/railwayTransport.txt");
            foreach (var fileLine in file)
            {
                string[] decemitional_0 = { " ", "  ", "\t" };
                string[] fileElement = fileLine.Split(decemitional_0,
                    StringSplitOptions.RemoveEmptyEntries);
                List<string> route = new List<string>();
                List<DateTime> time = new List<DateTime>();
                for (int i = 2; i < fileElement.Length; i+=2)
                {
                    route.Add(fileElement[i]);
                    time.Add(DateTime.Parse(fileElement[i + 1]));
                }
                _railwayTransports.Add(new RailwayTransport(fileElement[0], fileElement[1], route, time));
            }
        }

        void ReadRiverTramFromFile()
        {
            var file = File.ReadAllLines("../../Transport/riverTrams.txt");
            foreach (var fileLine in file)
            {
                string[] decemitional_0 = { " ", "  ", "\t"};
                string[] fileElement = fileLine.Split(decemitional_0,
                    StringSplitOptions.RemoveEmptyEntries);
                _riverTrams.Add(new RiverTram(DateTime.Parse(fileElement[2]), DateTime.Parse(fileElement[3]),
                    fileElement[0], fileElement[1]));
            }
        }

        public void Print(ListBox informationListBox, string transport)
        {
            informationListBox.Items.Clear();
            if (transport.ToLower() == "bus")
            {
                foreach (var elem in _buses)
                {
                   informationListBox.Items.Add(elem.Print());
                }
            }
            else if (transport.ToLower() == "river tram")
            {
                int number = 1;
                foreach (var elem in _riverTrams)
                {
                    informationListBox.Items.Add(elem.Print(number));
                    number++;
                }
            }
            else if (transport.ToLower() == "railway transport")
            {
                int number = 1;
                foreach (var elem in _railwayTransports)
                {
                    informationListBox.Items.Add(elem.Print(number));
                    number++;
                }
            }
        }

        public void GetBusFromNumber(ListBox informationListBox, string number)
        {
            informationListBox.Items.Clear();
            foreach (Bus bus in _buses)
            {
                string route = bus.GetRoutFromNumber(number);
                if(route!=null)
                {
                    informationListBox.Items.Add(route);
                    break;
                }
            }
        }

        public void GetTransportFromPointDepartue(ListBox informationListBox, string pointOfDepartue)
        {
            int number = 1;
            informationListBox.Items.Clear();
            if (_railwayTransports.Any(r => r.GetPointOfDeparture().ToLower().Contains(pointOfDepartue.ToLower())))
            {
                foreach (var elem in _railwayTransports)
                {
                    if (elem.GetPointOfDeparture().ToLower() == pointOfDepartue.ToLower())
                    {
                        informationListBox.Items.Add(elem.Print(number));
                        number++;
                    }
                }
            }
            if (_riverTrams.Any(r => r.GetDeparturePier().ToLower().Contains(pointOfDepartue.ToLower())))
            {
                foreach (var elem in _riverTrams)
                {
                    if (elem.GetDeparturePier().ToLower() == pointOfDepartue.ToLower())
                    {
                        informationListBox.Items.Add(elem.Print(number));
                        number++;
                    }
                }
            }
        }

        public void GetTransportFromPointArrival(ListBox informationListBox, string pointOfArrival)
        {
            informationListBox.Items.Clear();
            int number = 1;
            if (_railwayTransports.Any(r => r.GetPointOfArrival().ToLower().Contains(pointOfArrival.ToLower())))
            {
                foreach (var elem in _railwayTransports)
                {
                    if (elem.GetPointOfArrival().ToLower() == pointOfArrival.ToLower())
                    {
                        informationListBox.Items.Add(elem.Print(number));
                        number++;
                    }
                }
            }
            else if (_riverTrams.Any(r => r.GetArrivalPier().ToLower().Contains(pointOfArrival.ToLower())))
            {
                foreach (var elem in _riverTrams)
                {
                    if (elem.GetArrivalPier().ToLower() == pointOfArrival.ToLower())
                    {
                        informationListBox.Items.Add(elem.Print(number));
                        number++;
                    }
                }
            }
        }

        public static bool EditingRailwayTransport(int number, string pointOfDeparture, string pointOfArrival, List<string> path,
            List<DateTime> timePath, List<RailwayTransport> _railwayTransports)
        {
            for(int i=1; i<=_railwayTransports.Count;i++)
            {
                if(i==number)
                {
                    _railwayTransports[i-1].SetRailwayTransport(pointOfDeparture,pointOfArrival,path,timePath);
                    break;
                }
            }
            return true;
        }

        public static bool EditingBusTransport(string number, int interval, List<string> route, List<Bus> _buses)
        {
            foreach(Bus bus in _buses)
            {
                bus.SetBus(number, interval, route);
            }

            return true;
        }

        public static bool EditingRiverTram(int number, DateTime departureTime, DateTime arrivalTime,
            string departurePier, string arrivalPier, List<RiverTram> _riverTrams)
        {
            for (int i = 1; i <= _riverTrams.Count; i++)
            {
                if (i == number)
                {
                    _riverTrams[i-1].SetRiverTram(departureTime, arrivalTime, 
                        departurePier, arrivalPier);
                    break;
                }
            }

            return true;
        }

        public void SaveInformation()
        {
            SaveBus();
            SaveRailwayTransport();
            SaveRiverTram();
        }

        void SaveRailwayTransport()
        {
            File.Delete("../../Transport/railwayTransport.txt");
            foreach(RailwayTransport railway in _railwayTransports)
            {
                railway.Save("../../Transport/railwayTransport.txt");
            }
        }

        void SaveBus()
        {
            File.Delete("../../Transport/buses.txt");
            foreach(Bus bus in _buses)
            {
                bus.Save("../../Transport/buses.txt");
            }
        }

        void SaveRiverTram()
        {
            File.Delete("../../Transport/riverTrams.txt");
            foreach(RiverTram riverTram in _riverTrams)
            {
                riverTram.Save("../../Transport/riverTrams.txt");
            }
        }
    }
}
