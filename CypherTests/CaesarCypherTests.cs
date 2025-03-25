using RpgCyphers;

namespace CypherTests {
	[TestClass]
	public sealed class CaesarCypherTests {
		[TestMethod]
		public void EncodeWorks() {
			var actual = new CaesarCypher().Encode("Caesar cypheR");
			const string expected = "Fdhvdu fbskhU";

			Assert.AreEqual(expected, actual, ignoreCase: false);
		}

		[TestMethod]
		public void EncodeReversesWithNegativeOffset() {
			var encoder = new CaesarCypher(3);
			var decoder = new CaesarCypher(-3);

			const string expected = "Caesar cypheR";

			var encoded = encoder.Encode(expected);
			var decoded = decoder.Encode(encoded);

			Assert.AreEqual(expected, decoded, ignoreCase: false);
		}

		[TestMethod]
		public void CharsNotInAlphabetIgnored() {
			var actual = new CaesarCypher(1, "abc").Encode("abcdefghi3");
			const string expected = "bcadefghi3";

			Assert.AreEqual(expected, actual, ignoreCase: false);
		}
	}
}
