using System;
using System.Linq;

namespace aoj.volume0 {
	class _0070 : Problem {
		private static void CreateMem(int[,] dp, int rank, int sum, bool[] mem) {
			if (rank > 10) return;
			for(int i = 0; i < 10; i++) {
				if (mem[i]) continue;
				mem[i] = true;
				dp[rank, sum + rank * i]++;
				CreateMem(dp, rank + 1, sum + rank * i, mem);
				mem[i] = false;
			}
		}
		public override void Run() {
			var dp = new int[11,331];
			CreateMem(dp, 1, 0, new bool[10]);
			string str;
			while((str = Console.ReadLine())!= null) {
				var data = str.Split().Take(2).Select(int.Parse).ToArray();
				Console.WriteLine((data[1] > 330) ? 0 : dp[data[0], data[1]]);
			}
		}
	}
}