using CommandLine;

namespace RpgCypher.Options {
	[Verb("rail", HelpText = "Use a rail cypher to encypher the plaintext.")]
	public class RailCypherOptions : BaseOptions {
		[Option('r', "rails", Required = false, HelpText = "Number of rails to use.")]
		public int Rails { get; set; } = 3;

		[Option('f', "fillchar", Required = false, HelpText = "Character to fill \"extra\" cells with.")]
		public char FillChar { get; set; } = 'X';
	}
}
