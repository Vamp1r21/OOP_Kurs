using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KP_2Kurs
{
    class Path
    {
        List<Point> _points = new List<Point>();

        public Path(List<string> namePoint, List<DateTime> timePoint)
        {
            for (int i = 0; i < namePoint.Count; i++)
            {
                _points.Add(new Point(namePoint[i], timePoint[i]));
            }
        }

        public string GetPath()
        {
            string path = "";
            foreach (Point point in _points)
            {
                path += $"{point.GetInfo()} ";
            }
            return path;
        }

        public void SetPath(List<string> namePoint, List<DateTime> timePoint)
        {
            ClearPath();
            for (int i = 0; i < namePoint.Count; i++)
            {
                _points.Add(new Point(namePoint[i], timePoint[i]));
            }
        }

        void ClearPath()
        {
            _points.Clear();
        }
    }
}
