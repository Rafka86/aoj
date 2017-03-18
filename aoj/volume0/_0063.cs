using System;

namespace aoj {
	public class _0063 {
		public _0063() {
		}

		public void Run() {
			string str;
			int c = 0;
			while ((str = Console.ReadLine()) != null) {
				int i = 0;
				while(i < str.Length && str[i] == str[str.Length - i - 1]) i++;
				c += (i == str.Length) ? 1 : 0;
			}
			Console.WriteLine(c);
		}
	}
}