using System;

namespace aoj {
	public class _0066 {
		public _0066() {
		}

		public char Check(char[,] map) {
			if (map[1, 0] == map[1, 1] && map[1, 1] == map[1, 2] && map[1, 0] != 's') return map[1, 0];
			if (map[0, 1] == map[1, 1] && map[1, 1] == map[2, 1] && map[0, 1] != 's') return map[0, 1];
			if (map[0, 0] == map[1, 1] && map[1, 1] == map[2, 2] && map[0, 0] != 's') return map[0, 0];
			if (map[0, 2] == map[1, 1] && map[1, 1] == map[2, 0] && map[0, 2] != 's') return map[0, 2];
			if (map[0, 0] == map[0, 1] && map[0, 1] == map[0, 2] && map[0, 0] != 's') return map[0, 0];
			if (map[0, 0] == map[1, 0] && map[1, 0] == map[2, 0] && map[0, 0] != 's') return map[0, 0];
			if (map[2, 2] == map[2, 1] && map[2, 1] == map[2, 0] && map[2, 2] != 's') return map[2, 2];
			if (map[2, 2] == map[1, 2] && map[1, 2] == map[0, 2] && map[2, 2] != 's') return map[2, 2];
			return 'd';
		}

		public void Run() {
			string str;
			while ((str = Console.ReadLine()) != null) {
				char[,] map = { { str[0], str[1], str[2] }, { str[3], str[4], str[5] }, { str[6], str[7], str[8] } };
				Console.WriteLine(Check(map));
			}
		}
	}
}