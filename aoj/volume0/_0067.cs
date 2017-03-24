using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoj {
	struct Point {
		public int x { get; }
		public int y { get; }
		public Point(int x, int y) {
			this.x = x;
			this.y = y;
		}
	}
	class _0067 {
		public _0067() {
		}

		private bool InRange(int val) {
			return 0 <= val && val < 12;
		}

		public void Run() {
			var s = new Stack<Point>();
			var map = new int[12,12];
			var dx = new int[] {-1, 0, 1, 0};
			var dy = new int[] {0, -1, 0, 1};
			string str;
			while((str = Console.ReadLine()) != null) {
				int c = 0;
				for (int i = 0; i < str.Length; i++) map[0, i] = str[i] - '0';
				for (int i = 1; i < map.GetLength(0); i++) {
					str = Console.ReadLine();
					for (int j = 0; j < str.Length; j++) map[i, j] = str[j] - '0';
				}
				for (int i = 0; i < map.GetLength(0); i++) {
					for (int j = 0; j < map.GetLength(1); j++) {
						if (map[i, j] == 1) {
							s.Push(new Point(i, j));
							map[i, j] = 0;
							while (s.Count != 0) {
								var p = s.Pop();
								for(int k = 0; k < dx.Length; k++) {
									if (InRange(p.x + dx[k]) && InRange(p.y + dy[k]) && map[p.x + dx[k], p.y + dy[k]] == 1) {
										map[p.x + dx[k], p.y + dy[k]] = 0;
										s.Push(new Point(p.x + dx[k], p.y + dy[k]));
									}
								}
							}
							c++;
						}
					}
				}
				Console.WriteLine(c);
				Console.ReadLine();
			}
		}
	}
}
