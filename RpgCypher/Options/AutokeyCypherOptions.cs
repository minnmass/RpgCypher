using CommandLine;

namespace Cypher.Options {
	[Verb("autokey", HelpText = "Use an autokey cypher. The text of the message is appended to the key to lengthen the key.")]
	public class AutokeyCypherOptions : KeyedOption {
	}
}
