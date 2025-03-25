using RpgCyphers;

namespace CypherTests {
	[TestClass]
	public sealed class AutokeyCypherTests {
		[TestMethod]
		public void EncodeWorks() {
			var actual = new AutokeyCypher("queenly").Encode("attackatdawn");
			const string expected = "qnxepvytwtwp";

			Assert.AreEqual(expected, actual, ignoreCase: false);
		}
	}
}
