using Serilog;
using Serilog.Formatting.Compact;
using System;

namespace SerilogFun
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Log.Logger = new LoggerConfiguration()
                            .MinimumLevel.Debug()
                            .WriteTo.File(new CompactJsonFormatter(), "log.clef")
                            .CreateLogger();*/

            Log.Logger = new LoggerConfiguration()
                .Enrich.With<EventTypeEnricher>()
                .WriteTo.Console(outputTemplate:
                    "{Timestamp:HH:mm:ss} [{EventType:x8} {Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();

            var itemCount = 3;
            double itemTotal = 0;
            for (var itemNumber = 0; itemNumber < itemCount; ++itemNumber)
            {
                itemTotal = Math.Pow(2, itemNumber);
                Log.Information("Computed Iteration {ItemNumber}, total is {ItemTotal}", itemNumber, itemTotal);
            }

            Log.CloseAndFlush();
        }
    }
}
