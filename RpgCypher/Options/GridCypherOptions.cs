using CommandLine;

using RpgCypher.Options;

namespace Cypher.Options {
	[Verb("grid", HelpText = "Use a grid cypher.")]
	public class GridCypherOptions : BaseOptions {
		[Option('w', "width", Required = false, HelpText = "Width of the grid to use.")]
		public int Width { get; set; } = 4;
	}
}
