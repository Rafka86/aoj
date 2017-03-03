using System;
using System.Linq;

namespace aoj {
	public class _0060 {
		public _0060() {
		}

		public void Run() {
			string str;
			while((str = Console.ReadLine()) != null) {
				var vs = str.Split().Take(3).Select(s => byte.Parse(s)).ToArray();
				var uc = (new byte[10]).Select(v => 1).ToArray();
				uc[vs[0] - 1] = uc[vs[1] - 1] = uc[vs[2] - 1] = 0;
				Console.WriteLine(((double)(uc.Take((20 - vs[0] - vs[1] > 10) ? 10 : 20 - vs[0] - vs[1]).Sum()) / 7.0 < 0.5) ? "NO" : "YES");
			}
		}
	}
}