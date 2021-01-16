using Spectre.Console.Cli;

namespace Life.Commands.Add
{
    public class DaySettings : CommandSettings
    {
        [CommandArgument(0, "[day]")]
        public string? Day { get; set; }
    }

    public class DayPackageSettings : DaySettings
    {
        [CommandArgument(0, "<PACKAGE_NAME>")]
        public string? PackageName { get; set; }

        [CommandOption("-v|--version <VERSION>")]
        public string? Version { get; set; }
    }

    public class DayReferenceSettings : DaySettings
    {
        [CommandArgument(0, "<PROJECT_REFERENCE>")]
        public string? ProjectReference { get; set; }
    }
}