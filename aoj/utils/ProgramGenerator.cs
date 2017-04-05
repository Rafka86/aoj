using System.IO;
using static System.Console;

namespace aoj {
	static class ProgramGenerator {
		public static void Generate(string main, params string[] subs) {
			Write("Do you want to generate a program file for your submit? (y/n) : ");
			var ch = ReadLine().ToLower();
			if (!(ch == "y" || ch == "yes"))
				return;

			using (StreamWriter sw = new StreamWriter(@"../../submit.cs")) {
				using (StreamReader sr = new StreamReader(main)) {
					string line;
					while((line = sr.ReadLine()) != null) {
						if (line.Contains("namespace")) {
							sw.WriteLine(line);
							for (int i = 0; i < subs.Length; i++) {
								using (StreamReader ssr = new StreamReader(subs[i])) {
									string sline;
									while ((sline = ssr.ReadLine()) != null)
										if (sline != "" && !sline.Contains("namespace") && sline != "}")
											sw.WriteLine(sline);
								}
							}
						} else if (line.Contains(" : Problem")) {
							line = line.Replace(" : Problem", "");
							sw.WriteLine(line);
						} else if (line.Contains("override")) {
							line = line.Replace("override", "static");
							line = line.Replace("Run", "Main");
							sw.WriteLine(line);
						} else {
							sw.WriteLine(line);
						}
					}
				}
			}
		}
	}
}
