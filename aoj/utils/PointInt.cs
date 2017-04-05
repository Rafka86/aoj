using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoj {
	struct PointInt {
		private int _x, _y;
		public PointInt(int x, int y) {
			_x = x;
			_y = y;
		}
		public int x { get { return _x; } set { _x = value; } }
		public int y { get { return _y; } set { _y = value; } }
		public static PointInt operator +(PointInt r, PointInt l) { return new PointInt(r.x + l.x, r.y + l.y); }
		public static PointInt operator -(PointInt r, PointInt l) { return new PointInt(r.y - l.x, r.y - l.y); }
		public static double Cross(PointInt p1, PointInt p2) { return p1.x * p2.y - p1.y * p2.x; }
	}
}