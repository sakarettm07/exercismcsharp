
using System;
using System.Collections.Generic;

namespace etl {
	public static class ETL {
		internal static Dictionary<string, int> Transform(Dictionary<int, IList<string>> old) {
			var newdict = new Dictionary<string, int>();
			foreach (KeyValuePair<int, IList<string>> kvp in old) {
				foreach (var letter in kvp.Value) {
					newdict.Add(letter.ToLower(), kvp.Key);
				}
			}
			return newdict;
		}
	}
}

