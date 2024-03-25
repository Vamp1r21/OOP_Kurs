using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KP_2Kurs
{
    class Stop
    {
        string _nameBusStop;

        public Stop(string nameBusStop)
        {
            _nameBusStop = nameBusStop;
        }

        public string GetStop()
        {
            return _nameBusStop;
        }
    }
}
