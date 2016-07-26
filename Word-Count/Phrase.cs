using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace word_count {
	class Phrase {
		internal static Dictionary<string, int> WordCount(string v) {
			v = v.Trim();
			string pattern = @"\W+";
			var rgx = new Regex(pattern);
			string[] result = rgx.Split(v);

			var count = new Dictionary<string, int>();

			foreach (var item in result) {
				if (item.Length > 0) {
					if (count.ContainsKey(item)) {
						count[item] += 1;
					}
					else count.Add(item, 1);
				}
			}
			foreach (var item in count.Keys) {
				Console.Write(item);
				Console.WriteLine(count[item]);
			}

			return count;
		}
	}
}