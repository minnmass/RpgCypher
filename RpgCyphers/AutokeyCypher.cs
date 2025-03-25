namespace RpgCyphers {
	public class AutokeyCypher(string key) : ICypher {

		public string Encode(string input) {
			var vigKey = $"{key}{input}";
			var vig = new VigenèreCypher(vigKey);
			return vig.Encode(input);
		}
	}
}
