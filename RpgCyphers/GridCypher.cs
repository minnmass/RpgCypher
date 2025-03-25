namespace RpgCyphers {
	public class GridCypher(int width, char fillCharacter = 'X') : ICypher {
		public string Encode(string input) {
			var field = BuildField(input);

			var resultList = BuildResultList(field);

			return new string([.. resultList]).TrimEnd();

			List<char[]> BuildField(string input) {
				List<char[]> field = [];

				int colIdx = 0;
				var currentRow = GetNextArray();
				bool currentRowDirty = false;
				foreach (var c in input.Where(c => !char.IsWhiteSpace(c))) {
					if (colIdx == width) {
						colIdx = 0;
						field.Add(currentRow);
						currentRow = GetNextArray();
						currentRowDirty = false;
					}
					currentRow[colIdx] = c;
					++colIdx;
					currentRowDirty = true;
				}
				if (currentRowDirty) {
					field.Add(currentRow);
				}

				return field;

				char[] GetNextArray() {
					var array = new char[width];
					Array.Fill(array, fillCharacter);
					return array;
				}
			}

			List<char> BuildResultList(List<char[]> field) {
				List<char> resultList = [];

				for (int colIdx = 0; colIdx < width; ++colIdx) {
					foreach (var row in field) {
						resultList.Add(row[colIdx]);
					}
					resultList.Add(' ');
				}

				return resultList;
			}
		}
	}
}
