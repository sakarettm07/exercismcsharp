using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace word_count {
	class Phrase {
		internal static Dictionary<string, int> WordCount(string v) {
			v = v.Trim().ToLower();
			string pattern = @"[ ,]";
			var rgx = new Regex(pattern);
			string[] result = rgx.Split(v);

			var count = new Dictionary<string, int>();

			foreach (var item in result) {
				var word = item.Trim(new char[] { ' ', '.', ',', ':', '!', '?', '#', '@', '%', '$', '^', '&', '\'' });
				if (word.Trim().Length > 0) {
					if (count.ContainsKey(word)) {
						count[word] += 1;
					}
					else count.Add(word, 1);
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