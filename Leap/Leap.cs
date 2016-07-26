namespace leap
{
	public static class Year{

		internal static bool IsLeap(int v){
			if (v % 400 == 0 || (v % 4 == 0 && v % 100 != 0)) {
				return true;
			}
			else return false;
		}
	}
}

