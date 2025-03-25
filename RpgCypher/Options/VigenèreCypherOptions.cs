using CommandLine;

namespace Cypher.Options {
	[Verb("vigenère", aliases: ["vigenere", "vig"], HelpText = "Use a Vigenère cypher - like a Caesar cypher, but each character based on the key.")]
	public class VigenèreCypherOptions : KeyedOption {
	}
}
