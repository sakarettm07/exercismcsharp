namespace bob {
	public static class Bob {

		internal static string Hey(string v) {
			v = v.Trim();
			if (v.Length == 0) return "Fine. Be that way!";
			bool shouting = (v == v.ToUpper() && v.ToUpper() != v.ToLower());

			if (shouting) {
				return "Whoa, chill out!";
			}
			else if (v.EndsWith("?")) {
				return "Sure.";
			}

			else return "Whatever.";

		}
	}
}

