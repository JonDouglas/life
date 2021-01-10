using System;
using life.Commands.Add;
using life.Commands.View;
using Spectre.Console.Cli;

namespace life
{
    class Program
    {
        public static int Main(string[] args)
        {
            var app = new CommandApp();

            app.Configure(config =>
            {
                config.AddExample(new [] {"day", "create"});
                config.AddExample(new [] {"week", "view", "4"});
                config.AddBranch<DaySettings>("day", add =>
                {
                    add.AddCommand<CreateDayCommand>("create");
                    add.AddCommand<ViewDayCommand>("view");
                });
            });

            return app.Run(args);
        }
    }
}