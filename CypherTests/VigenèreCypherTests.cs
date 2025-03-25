using RpgCyphers;

namespace CypherTests {
	[TestClass]
	public sealed class VigenèreCypherTests {
		[TestMethod]
		public void EncodeWorks() {
			const string input = "attacking tonight";
			const string key = "oculorhinolaryngology";
			const string expected = "ovnlqbpvt eoegtnh";

			var actual = new VigenèreCypher(key).Encode(input);

			Assert.AreEqual(expected, actual, ignoreCase: false);
		}
	}
}
