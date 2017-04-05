using System.IO;
using static System.Console;

namespace aoj {
	static class Tester {
		public static void DoTest(Problem target, string inputFilePath) {
			var def = In;
			using (var sr = new StreamReader(inputFilePath)) {
				SetIn(sr);
				target.Run();
			}
			SetIn(def);
			Write("Press any key pls.");
			ReadLine();
		}
	}
}