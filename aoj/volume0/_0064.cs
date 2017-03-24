using System;

namespace aoj {
	public class _0064 : Problem {
		public override void Run() {
			string str;
			int r = 0;
			while ((str = Console.ReadLine()) != null)
				for (int i = 0; i < str.Length; i++)
					if ('0' <= str[i] && str[i] <= '9') {
						int s = i, l = 1;
						while (++i < str.Length && '0' <= str[i] && str[i] <= '9') l++;
						r += int.Parse(str.Substring(s, l));
					}
			Console.WriteLine(r);
		}
	}
}