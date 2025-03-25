namespace RpgCyphers {
	public class CaesarCypher(int offset = 3, string alphabet = "abcdefghijklmnopqrstuvwxyz") : ICypher {
		public string Encode(string input) {
			if (string.IsNullOrEmpty(input) || offset == 0) {
				return input;
			}

			var result = new char[input.Length];
			for (int i = 0; i < input.Length; ++i) {
				var cToUse = input[i];
				var cToCheck = char.ToLowerInvariant(cToUse);

				var baseIndex = alphabet.IndexOf(cToCheck);
				if (baseIndex >= 0) {
					var newIndex = baseIndex + offset + alphabet.Length;
					newIndex %= alphabet.Length;
					var newChar = alphabet[newIndex];
					if (char.IsUpper(cToUse)) {
						newChar = char.ToUpperInvariant(newChar);
					}
					result[i] = newChar;
				} else {
					result[i] = cToUse;
				}
			}

			return new string(result);
		}
	}
}
