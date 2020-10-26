using Murmur;
using Serilog.Core;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace SerilogFun
{
    // Install-Package Murmurhash
    class EventTypeEnricher : ILogEventEnricher
    {
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            var murmur = MurmurHash.Create32();
            var bytes = Encoding.UTF8.GetBytes(logEvent.MessageTemplate.Text);
            var hash = murmur.ComputeHash(bytes);
            var numericHash = BitConverter.ToUInt32(hash, 0);
            var eventType = propertyFactory.CreateProperty("EventType", numericHash);
            logEvent.AddPropertyIfAbsent(eventType);
        }
    }
}
