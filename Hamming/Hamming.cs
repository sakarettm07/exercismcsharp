namespace hamming {
	public static class Hamming {

		internal static int Compute(string v1, string v2) {
			if((v1.Length == 0 && v2.Length == 0) || v1.Equals(v2)){
				return 0;
			}
			char[] left = v1.ToCharArray();
			char[] right = v2.ToCharArray();

			int diffs = 0;

			for (int i = 0; i < v1.Length; i++) {
				if (left[i] != right[i]) diffs++;
			}
			return diffs;
		}
	}
}

