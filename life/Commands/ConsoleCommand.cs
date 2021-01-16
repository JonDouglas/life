using System.Threading.Tasks;
using Life.Commands.Settings;
using Microsoft.Extensions.Logging;
using Spectre.Console.Cli;

namespace Life.Commands
{
    public class ConsoleCommand : AsyncCommand<ConsoleSettings>
    {
        private ILogger Logger { get; }

        public override async Task<int> ExecuteAsync(CommandContext context, ConsoleSettings settings)
        {
            Logger.LogInformation("Mandatory: {Mandatory}", settings.Mandatory);
            Logger.LogInformation("Optional: {Optional}", settings.Optional);
            Logger.LogInformation("CommandOptionFlag: {CommandOptionFlag}", settings.CommandOptionFlag);
            Logger.LogInformation("CommandOptionValue: {CommandOptionValue}", settings.CommandOptionValue);
            return await Task.FromResult(0);
        }

        public ConsoleCommand(ILogger<ConsoleCommand> logger)
        {
            Logger = logger;
        }
    }
}