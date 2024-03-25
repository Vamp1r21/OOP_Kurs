using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KP_2Kurs
{
    class Route
    {
        List<Stop> _stops = new List<Stop>();

        public Route(List<string> stops)
        {
            foreach (string stop in stops)
            {
                _stops.Add(new Stop(stop));
            }
        }

        public string GetRoute()
        {
            string route = "";
            foreach (var stop in _stops)
            {
                route += $"{stop.GetStop()} ";
            }
            return route;
        }

        public void SetRoute(List<string> stops)
        {
            ClearRoute();
            foreach (string stop in stops)
            {
                _stops.Add(new Stop(stop));
            }
        }

        void ClearRoute()
        {
            _stops.Clear();
        }
    }
}
