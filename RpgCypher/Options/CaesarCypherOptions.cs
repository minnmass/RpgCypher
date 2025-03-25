using CommandLine;

namespace RpgCypher.Options {
	[Verb("caesar", HelpText = "Use a Caesar cypher to encypher the plaintext.")]
	public class CaesarCypherOptions : BaseOptions {
		[Option('o', "offset")]
		public int Offset { get; set; } = 3;
		[Option('a', "alphabet")]
		public string Alphabet { get; set; } = "abcdefghijklmnopqrstuvwxyz";
	}
}
