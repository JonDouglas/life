using Life.Commands;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Spectre.Cli.Extensions.DependencyInjection;
using Spectre.Console.Cli;

var serviceCollection = new ServiceCollection()
    .AddLogging(configure =>
        configure
            .AddSimpleConsole(options =>
            {
                options.TimestampFormat = "yyyy-MM-dd HH:mm:ss";
            })
        );

using var registrar = new DependencyInjectionRegistrar(serviceCollection);

var app = new CommandApp(registrar);

app.Configure(config =>
{
    config.ValidateExamples();
    
    config.AddCommand<ConsoleCommand>("console")
        .WithDescription("Example console command.")
        .WithExample(new[] { "console" });
    
    // config.AddExample(new [] {"day", "create"});
    // config.AddExample(new [] {"week", "view", "4"});
    // config.AddBranch<DaySettings>("day", add =>
    // {
    //     add.AddCommand<CreateDayCommand>("create");
    //     add.AddCommand<ViewDayCommand>("view");
    // });
});

return await app.RunAsync(args);