using RpgCyphers;

namespace CypherTests {
	[TestClass]
	public sealed class GridSypherTests {
		[TestMethod]
		public void EncodeWorks() {
			var actual = new GridCypher(4).Encode("ask for the hot soup");
			const string expected = "aoes srho ktou fhtp";

			Assert.AreEqual(expected, actual, ignoreCase: false);
		}

		[TestMethod]
		public void InputNotSquare_EncodeWorks() {
			var actual = new GridCypher(4).Encode("ask for the hot soups");
			const string expected = "aoess srhoX ktouX fhtpX";

			Assert.AreEqual(expected, actual, ignoreCase: false);
		}
	}
}
