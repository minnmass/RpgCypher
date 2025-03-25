using CommandLine;

using Cypher.Options;

using RpgCypher.Options;

using RpgCyphers;

namespace Cypher {
	internal class Program {
		internal static async Task Main(string[] args) {
			//args = ["vig", "-i", "input.txt", "--treatinputasfile", "--key", "stuffs"];

			var defaultparser = Parser.Default;
			var parseArguments = defaultparser.ParseArguments<RailCypherOptions, CaesarCypherOptions, GridCypherOptions, VigenèreCypherOptions, AutokeyCypherOptions>(args);
			var mapped = parseArguments.MapResult(
					(RailCypherOptions opts) => new ParsedInfo(opts, new RailCypher(opts.Rails)),
					(CaesarCypherOptions opts) => new ParsedInfo(opts, new CaesarCypher(opts.Offset, opts.Alphabet)),
					(GridCypherOptions opts) => new ParsedInfo(opts, new GridCypher(opts.Width)),
					(VigenèreCypherOptions opts) => new ParsedInfo(opts, new VigenèreCypher(opts.Key)),
					(AutokeyCypherOptions opts) => new ParsedInfo(opts, new AutokeyCypher(opts.Key)),
					errs => new(null, new NullCypher())
				);

			if (mapped.Options is null) {
				return;
			}

			var inputString = mapped.Options.TreatInputAsFile
				? await File.ReadAllTextAsync(mapped.Options.Input)
				: mapped.Options.Input;

			var encyphered = mapped.Cypher.Encode(inputString);

			Console.WriteLine(encyphered);
			if (!string.IsNullOrWhiteSpace(mapped.Options.OutputFile)) {
				await File.WriteAllTextAsync(mapped.Options.OutputFile, encyphered);
			}
		}

		private readonly struct ParsedInfo(BaseOptions? options, ICypher cypher) {
			public readonly BaseOptions? Options = options;
			public readonly ICypher Cypher = cypher;
		}
	}
}
