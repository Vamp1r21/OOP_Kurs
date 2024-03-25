using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_KP_2Kurs
{
    public class Bus
    {
        string _number;
        int _time;
        Route _route;

        public Bus(string number, int time, List<string> stops)
        {
            _number = number;
            _time = time;
            _route = new Route(stops);
        }

        public string Print()
        {
            return ($"Автобус:{_number}  Интервал:{_time} " +
                $" Маршрут:{_route.GetRoute()}");
        }

        public string GetRoutFromNumber(string number)
        {
            if(_number.ToLower()==number.ToLower())
            {
                return _route.GetRoute();
            }
            else
            {
                return null;
            }
        }

        public void SetBus(string number, int interval, List<string> route)
        {
            if (_number == number)
            {
                _time = interval;
                _route.SetRoute(route);
            }
        }

        public void Save(string fileName)
        {
            File.AppendAllText(fileName, $"{_number} {_time} {_route.GetRoute()}\n");
        }
    }
}
