using CommandLine;

using RpgCypher.Options;

namespace Cypher.Options {
	public class KeyedOption : BaseOptions {
		[Option('k', "key", Required = true, HelpText = "Key to use for the cypher.")]
		public string Key { get; set; } = string.Empty;
	}
}
