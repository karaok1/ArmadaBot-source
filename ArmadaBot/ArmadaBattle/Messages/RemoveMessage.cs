﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using ArmadaBot;
//
//    var removeMessage = RemoveMessage.FromJson(jsonString);

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArmadaBot.ArmadaBattle.Messages
{
    [System.Reflection.ObfuscationAttribute(Feature = "renaming", ApplyToMembers = true)]
    public partial class RemoveMessageClass
    {
        [JsonProperty("gameObjectType", NullValueHandling = NullValueHandling.Ignore)]
        public string GameObjectType { get; set; }

        [JsonProperty("gameObjectId", NullValueHandling = NullValueHandling.Ignore)]
        public string GameObjectId { get; set; }
    }

    public partial struct RemoveMessageElement
    {
        public RemoveMessageClass RemoveMessageClass;
        public string String;

        public static implicit operator RemoveMessageElement(RemoveMessageClass RemoveMessageClass) => new RemoveMessageElement { RemoveMessageClass = RemoveMessageClass };
        public static implicit operator RemoveMessageElement(string String) => new RemoveMessageElement { String = String };
    }

    public class RemoveMessage
    {
        public static List<RemoveMessageElement> FromJson(string json) => JsonConvert.DeserializeObject<List<RemoveMessageElement>>(json, Converter.Settings);
    }

    internal class RemoveMessageElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RemoveMessageElement) || t == typeof(RemoveMessageElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new RemoveMessageElement { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<RemoveMessageClass>(reader);
                    return new RemoveMessageElement { RemoveMessageClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type RemoveMessageElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (RemoveMessageElement)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.RemoveMessageClass != null)
            {
                serializer.Serialize(writer, value.RemoveMessageClass);
                return;
            }
            throw new Exception("Cannot marshal type RemoveMessageElement");
        }

        public static readonly RemoveMessageElementConverter Singleton = new RemoveMessageElementConverter();
    }
}