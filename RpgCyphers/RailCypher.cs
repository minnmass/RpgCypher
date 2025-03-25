namespace RpgCyphers {
	public class RailCypher(int numRails = 3) : ICypher {
		public string Encode(string input) {
			if (string.IsNullOrWhiteSpace(input) || numRails < 2) {
				return input;
			}
			var rails = new List<char>[numRails];

			for (int i = 0; i < numRails; ++i) {
				rails[i] = [];
			}

			int offset = 1;
			int railIdx = 0;
			foreach (var c in input.Where(char.IsLetterOrDigit)) {
				rails[railIdx].Add(c);
				railIdx += offset;

				if (railIdx == -1 || railIdx == rails.Length) {
					offset *= -1;
					railIdx += offset + offset;
				}

			}

			var result = rails.SelectMany(c => c).ToArray();
			var resultStr = new string(result);
			return resultStr;
		}
	}
}
