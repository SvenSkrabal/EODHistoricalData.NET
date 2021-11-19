﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using EODHistoricalData.NET;
//
//    var instrument = Instrument.FromJson(jsonString);

namespace EODHistoricalData.NET
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Exchange
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        
        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("OperatingMIC")]
        public string OperatingMIC { get; set; }
        
        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("Currency")]
        public string Currency { get; set; }
    }


    public partial class Exchange
    {
        public static List<Exchange> FromJson(string json) => JsonConvert.DeserializeObject<List<Exchange>>(json, EODHistoricalData.NET.ConverterExchange.Settings);
    }

    public static class SerializeExchange
    {
        public static string ToJson(this List<Instrument> self) => JsonConvert.SerializeObject(self, EODHistoricalData.NET.ConverterExchange.Settings);
    }

    internal static class ConverterExchange
    {
        public static List<string> Errors = new List<string>();
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new NullConverter(),
            },
            Error = delegate (object sender, Newtonsoft.Json.Serialization.ErrorEventArgs args)
            {
                Errors.Add(args.ErrorContext.Error.Message);
                args.ErrorContext.Handled = true;
            },
        };
    }
}
