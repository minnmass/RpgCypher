using RpgCyphers;

namespace CypherTests {
	[TestClass]
	public sealed class RailCypherTests {
		[TestMethod]
		public void EncodeWorks() {
			var actual = new RailCypher(3).Encode("The Queen's Mage-Slayer wears red.");
			const string expected = "TuseyerhQenMgSaewaseeealrrd";

			Assert.AreEqual(expected, actual, ignoreCase: false);
		}
	}
}
