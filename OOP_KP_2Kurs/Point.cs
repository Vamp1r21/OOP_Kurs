using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KP_2Kurs
{
    class Point
    {
        string _name;
        DateTime _arrivalTime;

        public Point(string name, DateTime arrivalTime)
        {
            _name = name;
            _arrivalTime = arrivalTime;
        }

        public string GetInfo()
        {
            return $"{_name} {_arrivalTime.ToShortTimeString()}  ";
        }
    }
}
