using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoj {
	struct Point {
		private double _x, _y;
		public Point(double x, double y) {
			_x = x;
			_y = y;
		}
		public double x { get { return _x; } set { _x = value; } }
		public double y { get { return _y; } set { _y = value; } }
		public static Point operator+(Point r, Point l) { return new Point(r.x + l.x, r.y + l.y); }
		public static Point operator-(Point r, Point l) { return new Point(r.x - l.x, r.y - l.y); }
		public static double Cross(Point p1, Point p2) { return p1.x * p2.y - p1.y * p2.x; }
	}
}
