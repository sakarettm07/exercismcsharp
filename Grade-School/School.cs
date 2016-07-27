using System;
using System.Collections.Generic;

namespace grade_school {
	class School {
		internal Dictionary<int, List<string>> Roster;

		public School(){
			Roster = new Dictionary<int, List<string>>();
		}


		internal void Add(string name, int grade) {
			if (Roster.ContainsKey(grade)) {
				Roster[grade].Add(name);
				Roster[grade].Sort();
			}
			else{
				var newGrade = new List<string>();
				newGrade.Add(name);
				Roster[grade] = newGrade;
			} 
		}

		internal List<string> Grade(int v) {
			var gradeNames = new List<string>();

			if(Roster.ContainsKey(v)){
				gradeNames = Roster[v];
			}

			return gradeNames;
		}
}
}