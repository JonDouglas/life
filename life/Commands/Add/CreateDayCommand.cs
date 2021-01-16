// using System.Collections.Generic;
// using System.ComponentModel;
// using life.Utilities;
// using Spectre.Console;
// using Spectre.Console.Cli;
//
// namespace life.Commands.Add
// {
//     [Description("Add a NuGet package reference to the project.")]
//         public sealed class CreateDayCommand : Command<CreateDayCommand.Settings>
//         {
//             public sealed class Settings : DaySettings
//             {
//                 [CommandOption("-v|--version <VERSION>")]
//                 [Description("The version of the package to add.")]
//                 public string? Version { get; set; }
//
//                 [CommandOption("-f|--framework <FRAMEWORK>")]
//                 [Description("Add the reference only when targeting a specific framework.")]
//                 public string? Framework { get; set; }
//
//                 [CommandOption("--no-restore")]
//                 [Description("Add the reference without performing restore preview and compatibility check.")]
//                 public bool NoRestore { get; set; }
//
//                 [CommandOption("--source <SOURCE>")]
//                 [Description("The NuGet package source to use during the restore.")]
//                 public string? Source { get; set; }
//
//                 [CommandOption("--package-directory <PACKAGEDIR>")]
//                 [Description("The directory to restore packages to.")]
//                 public string? PackageDirectory { get; set; }
//
//                 [CommandOption("--interactive")]
//                 [Description("Allows the command to stop and wait for user input or action (for example to complete authentication).")]
//                 public bool Interactive { get; set; }
//             }
//
//             public override int Execute(CommandContext? context, Settings? settings)
//             {
//                 List<string> prompts = new List<string>();
//                 var grateful = AnsiConsole.Ask<string>("Today I'm grateful for:");
//                 var goal = AnsiConsole.Ask<string>("Today's Goal:");
//                 prompts.Add(grateful);
//                 prompts.Add(goal);
//                 SettingsDumper.DumpStrings(prompts);
//                 return 0;
//             }
//         
//     }
// }