// using System;
// using System.ComponentModel;
// using System.Threading.Tasks;
// using life.Commands.Add;
// using life.Utilities;
// using Spectre.Console;
// using Spectre.Console.Cli;
//
// namespace life.Commands.View
// {
//     [Description("View a day in your life.")]
//     public class ViewDayCommand : AsyncCommand<ViewDayCommand.Settings>
//     {
//         public sealed class Settings : DaySettings
//         {
//             [CommandArgument(0, "<DAY>")]
//             [Description("The day you want to view.")]
//             public string Day { get; set; }
//             
//             [CommandOption("-v|--version <VERSION>")]
//             [Description("The version of the package to add.")]
//             public string? Version { get; set; }
//
//             [CommandOption("-f|--framework <FRAMEWORK>")]
//             [Description("Add the reference only when targeting a specific framework.")]
//             public string? Framework { get; set; }
//
//             [CommandOption("--no-restore")]
//             [Description("Add the reference without performing restore preview and compatibility check.")]
//             public bool NoRestore { get; set; }
//
//             [CommandOption("--source <SOURCE>")]
//             [Description("The NuGet package source to use during the restore.")]
//             public string? Source { get; set; }
//
//             [CommandOption("--package-directory <PACKAGEDIR>")]
//             [Description("The directory to restore packages to.")]
//             public string? PackageDirectory { get; set; }
//
//             [CommandOption("--interactive")]
//             [Description("Allows the command to stop and wait for user input or action (for example to complete authentication).")]
//             public bool Interactive { get; set; }
//         }
//
//         public override async Task<int> Execute(CommandContext context, Settings settings)
//         {
//             SettingsDumper.DumpDayView(settings.Day);
//             
//             var calendar = new Calendar(DateTime.Now.Year, DateTime.Now.Month);
//             calendar.AddCalendarEvent(DateTime.Now);
//             calendar.HighlightStyle(Style.Parse("yellow bold"));
//             AnsiConsole.Render(calendar);
//             
//             // Create a table
//             var table = new Table();
//             table.Expand();
//             table.Centered();
//             table.Border = TableBorder.None;
//             
//             table.AddColumn(new TableColumn(new Markup("[yellow]Day[/]")).Centered());
//
//
//             table.AddRow(new Panel("[green]Pizza?[/]").Expand());
//             // table.AddRow(new Markup("[blue]Corgi[/]"), new Panel("Waldo"));
//             Panel p = new Panel("Hello World!");
//             p.Header = new PanelHeader("Did you say hello world yet?");
//             p.Expand();
//             p.Border = BoxBorder.None;
//             table.AddRow(p);
//             AnsiConsole.Render(table);
//             AnsiConsole.Markup(":tent:");
//             AnsiConsole.Progress().Columns(new ProgressColumn[] 
//                 {
//                     new TaskDescriptionColumn(),    // Task description
//                     new ProgressBarColumn(),        // Progress bar
//                     new PercentageColumn(),         // Percentage
//                     new RemainingTimeColumn(),      // Remaining time
//                     new SpinnerColumn(),            // Spinner
//                 })
//                 .Start(ctx => 
//                 {
//                     // Define tasks
//                     var task1 = ctx.AddTask("[green]Reticulating splines[/]");
//                     var task2 = ctx.AddTask("[green]Folding space[/]");
//
//                     while(!ctx.IsFinished)
//                     {
//                         Task.Delay(1000);
//                         task1.Increment(0.001);
//                         task2.Increment(0.005);
//                     }
//                 });
//             // List<string> prompts = new List<string>();
//             // var grateful = AnsiConsole.Ask<string>("Today I'm grateful for:");
//             // var goal = AnsiConsole.Ask<string>("Today's Goal:");
//             // prompts.Add(grateful);
//             // prompts.Add(goal);
//             // SettingsDumper.DumpStrings(prompts);
//             // return 0;
//             return 0;
//         }
//         
//     }
// }