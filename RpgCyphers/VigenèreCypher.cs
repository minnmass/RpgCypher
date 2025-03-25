namespace RpgCyphers {
	public class VigenèreCypher(string key) : ICypher {
		private const string _alphabet = "abcdefghijklmnopqrstuvwxyz";
		private static readonly char[] _alphabetLower = _alphabet.ToCharArray();
		private static readonly char[] _alphabetUpper = [.. _alphabet.Select(char.ToUpper)];

		public string Encode(string input) {
			Console.WriteLine($"<<{key}>>");

			var output = new char[input.Length];

			for (int idx = 0; idx < input.Length; ++idx) {
				char plainChar = input[idx];
				char cypherChar = plainChar;

				var alphabet = char.IsUpper(plainChar) ? _alphabetUpper : _alphabetLower;
				if (TryGetIndex(alphabet, plainChar, out var baseIdx)) {
					var keyChar = key[idx % key.Length];
					var keyAlphabet = char.IsUpper(keyChar) ? _alphabetUpper : _alphabetLower;
					if (TryGetIndex(keyAlphabet, keyChar, out var idxOffset)) {
						var newIdx = baseIdx + idxOffset;
						newIdx %= alphabet.Length;
						cypherChar = alphabet[newIdx];
					}
				}

				output[idx] = cypherChar;
			}

			return new string(output);

			static bool TryGetIndex(char[] chars, char target, out int index) {
				index = Array.BinarySearch(chars, target);
				return index >= 0;
			}
		}
	}
}
