using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoj {
	public class _0062 {
		public _0062() {
		}

		public void Run() {
			string str;
			while ((str = Console.ReadLine()) != null) {
				var ns = str.Select(c=>int.Parse(c.ToString())).ToArray();
				for (int i = 0; i < 9; i++) {
					for (int j = 0; j < 9 - i; j++) {
						var nc = (ns[j] + ns[j + 1]).ToString();
						ns[j] = int.Parse(nc[nc.Length - 1].ToString());
					}
				}
				Console.WriteLine(ns[0]);
			}
		}
	}
}
