namespace RpgCyphers {
	public class NullCypher : ICypher {
		public string Encode(string input) {
			return input;
		}
	}
}
