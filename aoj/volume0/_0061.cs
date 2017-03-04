using System;
using System.Linq;
using System.Collections.Generic;

namespace aoj {
	public class _0061 {
		public _0061() {
		}

		public void Run() {
			Dictionary<int, int> data, rank;
			List<int> points;
			data = new Dictionary<int, int>();
			rank = new Dictionary<int, int>();
			points = new List<int>();

			int[] vs;
			while(true) {
				vs = Console.ReadLine().Split(',').Take(2).Select(s => int.Parse(s)).ToArray();
				if (vs[0] == 0) break;
				data.Add(vs[0], vs[1]);
				points.Add(vs[1]);
			}
			points.Sort((a, b) => b - a);
			rank.Add(points[0], 1);
			int v = points[0], r = 2;
			for (int i = 1; i < points.Count; i++) {
				if (v == points[i]) continue;
				else {
					v = points[i];
					rank.Add(v, r++);
				}
			}
			string str;
			while((str = Console.ReadLine()) != null)
				Console.WriteLine(rank[data[int.Parse(str)]]);
		}
	}
}