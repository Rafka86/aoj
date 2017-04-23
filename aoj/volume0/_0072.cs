using System;

namespace aoj.volume0 {
	struct Edge {
		public int n1, n2, w;
		public Edge(int node1, int node2, int weight) { n1 = node1; n2 = node2; w = weight; }
	}
	public class _0072 : Problem {
		public override void Run() {
			string str;
			while((str = Console.ReadLine()) != "0") {
				var n = int.Parse(str);
				var m = int.Parse(Console.ReadLine());
			}
		}
	}
}