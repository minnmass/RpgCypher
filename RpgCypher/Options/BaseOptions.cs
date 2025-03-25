using CommandLine;

namespace RpgCypher.Options {
	public abstract class BaseOptions {
		[Option('i', "input", Required = true, HelpText = "String to encypher.")]
		public string Input { get; set; } = string.Empty;

		[Option(HelpText = "Treat input string as the path of a file instead of the text to be encyphered.")]
		public bool TreatInputAsFile { get; set; } = false;

		[Option(HelpText = "If non-empty, copy the encyphered text to the file.")]
		public string OutputFile { get; set; } = string.Empty;
	}
}
