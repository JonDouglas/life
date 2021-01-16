using System.Collections.Generic;
using Spectre.Console;
using Spectre.Console.Cli;

namespace Life.Utilities
{
    public static class SettingsDumper
    {
        public static void Dump(CommandSettings settings)
        {
            var table = new Table().RoundedBorder();
            table.AddColumn("[green]Name[/]");
            table.AddColumn("[red]Value[/]");

            var properties = settings.GetType().GetProperties();
            foreach (var property in properties)
            {
                var value = property.GetValue(settings)
                    ?.ToString()
                    ?.Replace("[", "[[");

                table.AddRow(
                    property.Name,
                    value ?? "[grey]null[/]");
            }

            AnsiConsole.Render(table);
        }
        
        public static void DumpStrings(List<string> dump)
        {
            var table = new Table().RoundedBorder();
            table.AddColumn("[green]Name[/]");

            foreach (var d in dump)
            {
                table.AddRow(d);
            }

            AnsiConsole.Render(table);
        }

        public static void DumpDayView(string day)
        {
            var table = new Table().RoundedBorder();
            table.AddColumn("[green]Name[/]");

            table.AddRow(day);

            AnsiConsole.Render(table);
        }
    }
}