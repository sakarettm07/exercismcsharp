using System;
using System.Collections.Generic;

namespace anagram {
	public class Anagram {
		string word, sortedword;


		public Anagram(string v) {
			word = v;
			sortedword = Sort(v);
		}


		internal string[] Match(string[] words) {
			var matches = new List<string>();

			foreach (var item in words) {
				string sorteditem = Sort(item);

				Console.WriteLine("word: "+word+" sortedword: "+sortedword+" item: "+item+" sorteditem: "+sorteditem);

				if(sortedword.Equals(sorteditem,StringComparison.CurrentCultureIgnoreCase)
				   && !word.Equals(item, StringComparison.CurrentCultureIgnoreCase)){
					matches.Add(item);
				}
			}
			string[] final = matches.ToArray();
			return final;
		}

		internal string Sort(string item) {
			string sorted;
			char[] foo = item.ToLower().ToCharArray();
			Array.Sort(foo);
			sorted = string.Join("", foo);

			return sorted;
		}
	}
}

