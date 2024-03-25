using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_KP_2Kurs
{
    public class RailwayTransport
    {
        string _pointOfDeparture;
        string _pointOfArrival;
        Path _path;

        public RailwayTransport(string pointOfDeparture, string pointOfArrival, 
            List<string> name, List<DateTime> time)
        {
            _pointOfArrival = pointOfArrival;
            _pointOfDeparture = pointOfDeparture;
            _path = new Path(name, time);
        }

        public string Print(int number)
        {
            return ($"{number} Железнодорожный транспорт: Пункт отправления:{_pointOfDeparture} Пункт прибытия:{_pointOfArrival} " +
                $"Пункт/Время прибытия:{_path.GetPath()}");
        }

        public string GetPointOfDeparture()
        {
            return _pointOfDeparture;
        }

        public string GetPointOfArrival()
        {
            return _pointOfArrival;
        }

        public void SetRailwayTransport(string pointOfDeparture, string pointOfArrival, List<string> path,
            List<DateTime> timePath)
        {
            _pointOfArrival = pointOfArrival;
            _pointOfDeparture = pointOfDeparture;
            _path.SetPath(path, timePath);
        }

        public void Save(string fileName)
        {
            File.AppendAllText(fileName, $"{_pointOfDeparture} {_pointOfArrival} {_path.GetPath()}\n");
        }
    }
}
