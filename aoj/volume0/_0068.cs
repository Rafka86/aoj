using System;
using System.Collections.Generic;
using System.Linq;

namespace aoj {
	class _0068 : Problem {
		static bool Turn2Right(Point p0, Point p1, Point p2) { return Point.Cross(p2 - p0, p1 - p0) > 0; }
		static int GrahamScan(Point[] ps) {
			Array.Sort(ps, (a, b) => (a.x < b.x) ? -1 : (a.x > b.x) ? 1 : 0);
			var p0 = ps[0];

			var args = new List<KeyValuePair<Point,double>>();
			for (int i = 1; i < ps.Length; i++) {
				var tp = ps[i] - p0;
				args.Add(new KeyValuePair<Point, double>(ps[i], Math.Atan2(tp.y, tp.x)));
			}
			args.Sort((a, b) => (a.Value < b.Value) ? -1 : (a.Value > b.Value) ? 1 : 0);
			for (int i = 1; i < ps.Length; i++)
				ps[i] = args[i - 1].Key;

			var s = new Stack<Point>();
			s.Push(ps[0]); s.Push(ps[1]); s.Push(ps[2]);
			for(int i = 3; i < ps.Length; i++) {
				var top = s.Pop();
				var n2t = s.Pop();
				while (Turn2Right(n2t, top, ps[i])) {
					top = n2t;
					n2t = s.Pop();
				}
				s.Push(n2t); s.Push(top); s.Push(ps[i]);
			}
			return ps.Length - s.Count;
		}
		public override void Run() {
			string str;
			while ((str = Console.ReadLine()) != "0") {
				var n = int.Parse(str);
				var points = new Point[n];
				for (int i = 0; i < n; i++) {
					var pos = Console.ReadLine().Split(',').Take(2).Select(double.Parse).ToArray();
					points[i].x = pos[0];	points[i].y = pos[1];
				}
				Console.WriteLine(GrahamScan(points));
			}
		}
	}
}