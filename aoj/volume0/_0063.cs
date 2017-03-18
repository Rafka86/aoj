using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoj {
	class _0063 {
		public _0063() {
		}

		public void Run() {
			string str;
			int s = 0;
			while((str = Console.ReadLine()) != null)
				if (str == string.Join("", str.Reverse())) s++;
			Console.WriteLine(s);
		}
	}
}
