using System;
using System.Collections.Generic;

namespace aoj {
	struct Save {
		public int now;
		public int stage;
		public int line;
		public Save(int n, int s, int l) {
			now = n; stage = s; line = l;
		}
	}
	class _0069 : Problem {
		public override void Run() {
			string str;
			while ((str = Console.ReadLine()) != "0") {
				var ln = int.Parse(str);
				var cn = int.Parse(Console.ReadLine());
				var hn = int.Parse(Console.ReadLine());
				var sn = int.Parse(Console.ReadLine());
				var hls = new string[sn];
				for (int i = 0; i < hls.Length; i++)
					hls[i] = "0" + Console.ReadLine() + "0";

				var nl = cn;
				var cand = new Queue<Save>();
				for (int i = 0; i < hls.Length; i++) {
					if (hls[i][nl - 1] == '1' || hls[i][nl] == '1') {
						nl += (hls[i][nl - 1] == '1') ? -1 : 1;
						continue;
					} else {
						if (1 < nl && hls[i][nl - 2] == '0') cand.Enqueue(new Save(nl, i, nl - 1));
						if (nl < ln && hls[i][nl + 1] == '0') cand.Enqueue(new Save(nl, i, nl));
					}
				}
				if (nl == hn) {
					Console.WriteLine("0");
					continue;
				}

				var found = false;
				while (cand.Count > 0) {
					var c = cand.Dequeue();
					nl = c.now + ((c.line == c.now) ? 1 : -1);
					for (int i = c.stage + 1; i < hls.Length; i++)
						nl += (hls[i][nl - 1] == '1') ? -1 : (hls[i][nl] == '1') ? 1 : 0;
					if (nl == hn) {
						found = true;
						Console.WriteLine((c.stage + 1) + " " + c.line);
						break;
					}
				}

				if (!found)
					Console.WriteLine("1");
			}
		}
	}
}