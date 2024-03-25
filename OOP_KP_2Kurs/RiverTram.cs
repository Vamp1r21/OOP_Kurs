using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_KP_2Kurs
{
    public class RiverTram
    {
        DateTime _departureTime;
        DateTime _arrivalTime;
        string _departurePier;
        string _arrivalPier;

        public RiverTram(DateTime departureTime, DateTime arrivalTime,
            string departurePier, string arrivalPier)
        {
            _departurePier = departurePier;
            _arrivalPier = arrivalPier;
            _departureTime = departureTime;
            _arrivalTime = arrivalTime;
        }

        public string Print(int number)
        {
            return ($"{number} Речной трамвай: Пристань отправления:{_departurePier}  Пристань прибытия:{_arrivalPier} " +
                $" Время отправления:{_departureTime.ToShortTimeString()}  " +
                $"Время прибытия:{_arrivalTime.ToShortTimeString()}");
        }

        public string GetDeparturePier()
        {
            return _departurePier;
        }

        public string GetArrivalPier()
        {
            return _arrivalPier;
        }

        public void SetRiverTram(DateTime departureTime, DateTime arrivalTime, 
            string departurePier, string arrivalPier)
        {
            _departurePier = departurePier;
            _arrivalPier = arrivalPier;
            _departureTime = departureTime;
            _arrivalTime = arrivalTime;
        }

        public void Save(string fileName)
        {
            File.AppendAllText(fileName, $"{_departurePier.ToString()} {_arrivalPier.ToString()} " +
                $"{_departureTime.ToShortTimeString()} {_arrivalTime.ToShortTimeString()}\n");
        }
    }
}
