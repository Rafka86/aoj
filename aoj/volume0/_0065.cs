using System;
using System.Linq;
using System.Collections.Generic;

namespace aoj {
	public class _0065 {
		public _0065() {
		}

		public void Run() {
			var d = new Dictionary<int, int>();
			var list = new List<int>();
			string str;
			while ((str = Console.ReadLine()) != null) {
				if (str == "") break;
				var data = str.Split(',').Take(2).Select(int.Parse).ToArray();
				if (!d.ContainsKey(data[0])) d.Add(data[0], 1);
				else d[data[0]]++;
			}
			while ((str = Console.ReadLine()) != null) {
				var data = str.Split(',').Take(2).Select(int.Parse).ToArray();
				if (d.ContainsKey(data[0])) {
					list.Add(data[0]);
					d[data[0]]++;
				}
			}
			var sl = list.Distinct().ToList();
			sl.Sort();
			foreach (int p in sl) Console.WriteLine(p + " " + d[p]);
		}
	}
}