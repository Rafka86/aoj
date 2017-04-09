using System;
using System.Collections.Generic;

namespace aoj.volume0 {
	class _0071 : Problem {
		public override void Run() {
			var n = int.Parse(Console.ReadLine());
			int[,] map = new int[8,8];
			for (int i = 0; i < n; i++) {
				Console.ReadLine();
				for (int j = 0; j < map.GetLength(0); j++) {
					var str = Console.ReadLine();
					for (int k = 0; k < str.Length; k++)
						map[j, k] = str[k] - '0';
				}
				var s = new Stack<PointInt>();
				s.Push(new PointInt(int.Parse(Console.ReadLine()) - 1, int.Parse(Console.ReadLine()) - 1));

				while (s.Count != 0) {
					var ep = s.Pop();
					map[ep.y, ep.x] = 2;
					for (int x = ep.x, c = 0; x >= 0 && c <= 3; x--, c++)
						if (map[ep.y, x] == 2) continue;
						else if (map[ep.y, x] == 1) { s.Push(new PointInt(x, ep.y)); map[ep.y, x] = 2; }
						else map[ep.y, x] = 2;
					for (int y = ep.y, c = 0; y >= 0 && c <= 3; y--, c++)
						if (map[y, ep.x] == 2) continue;
						else if (map[y, ep.x] == 1) { s.Push(new PointInt(ep.x, y)); map[y, ep.x] = 2; }
						else map[y, ep.x] = 2;
					for (int x = ep.x, c = 0; x < 8 && c <= 3; x++, c++)
						if (map[ep.y, x] == 2) continue;
						else if (map[ep.y, x] == 1) { s.Push(new PointInt(x, ep.y)); map[ep.y, x] = 2; }
						else map[ep.y, x] = 2;
					for (int y = ep.y, c = 0; y < 8 && c <= 3; y++, c++)
						if (map[y, ep.x] == 2) continue;
						else if (map[y, ep.x] == 1) { s.Push(new PointInt(ep.x, y)); map[y, ep.x] = 2; }
						else map[y, ep.x] = 2;
				}

				Console.WriteLine("Data " + (i + 1) + ":");
				for (int j = 0; j < map.GetLength(0); j++, Console.Write("\n"))
					for (int k = 0; k < map.GetLength(1); k++)
						Console.Write((map[j, k] == 2) ? 0 : map[j, k]);
			}
		}
	}
}