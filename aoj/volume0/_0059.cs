using System;
using System.Linq;

namespace aoj {
	public class _0059 {
		public _0059() {
		}

		public void Run() {
			string str;
			double[] vals;
			while((str = Console.ReadLine()) != null) {
				vals = str.Split().Take(8).Select(s => double.Parse(s)).ToArray();
				Console.WriteLine((vals[0] <= vals[6] && vals[4] <= vals[2] && vals[1] <= vals[7] && vals[5] <= vals[3]) ? "YES" : "NO");
			}
		}
	}
}