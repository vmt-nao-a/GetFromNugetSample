using System;
using System.Collections.Generic;

using System.Globalization;
using System.Runtime.Serialization;
using Utf8Json;

namespace GetFromNuGet
{

    public partial class Welcome
    {
        [DataMember(Name = "@context")]
        public Context Context { get; set; }

        [DataMember(Name = "totalHits")]
        public long TotalHits { get; set; }

        [DataMember(Name = "data")]
        public Datum[] Data { get; set; }
    }

    public partial class Context
    {
        [DataMember(Name = "@vocab")]
        public Uri Vocab { get; set; }

        [DataMember(Name = "@base")]
        public Uri Base { get; set; }
    }

    public partial class Datum
    {
        [DataMember(Name = "@id")]
        public Uri Id { get; set; }

        [DataMember(Name = "@type")]
        public TypeEnum Type { get; set; }

        [DataMember(Name = "registration")]
        public Uri Registration { get; set; }

        [DataMember(Name = "id")]
        public string DatumId { get; set; }

        [DataMember(Name = "version")]
        public string Version { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "summary")]
        public string Summary { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "iconUrl")]
        public Uri IconUrl { get; set; }

        //[DataMember(Name = "licenseUrl", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(Name = "licenseUrl")]
        public Uri LicenseUrl { get; set; }

        [DataMember(Name = "projectUrl")]
        public Uri ProjectUrl { get; set; }

        [DataMember(Name = "tags")]
        public string[] Tags { get; set; }

        [DataMember(Name = "authors")]
        public string[] Authors { get; set; }

        [DataMember(Name = "totalDownloads")]
        public long TotalDownloads { get; set; }

        [DataMember(Name = "verified")]
        public bool Verified { get; set; }

        [DataMember(Name = "packageTypes")]
        public PackageType[] PackageTypes { get; set; }

        [DataMember(Name = "versions")]
        public Version[] Versions { get; set; }
    }

    public partial class PackageType
    {
        [DataMember(Name = "name")]
        public Name Name { get; set; }
    }

    public partial class Version
    {
        [DataMember(Name = "version")]
        public string VersionVersion { get; set; }

        [DataMember(Name = "downloads")]
        public long Downloads { get; set; }

        [DataMember(Name = "@id")]
        public Uri Id { get; set; }
    }

    public enum Name { Dependency };

    public enum TypeEnum { Package };

//    public partial class Welcome
//    {
//        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, QuickType.Converter.Settings);
//    }
//
//    public static class Serialize
//    {
//        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
//    }
//
//    internal static class Converter
//    {
//        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
//        {
//            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
//            DateParseHandling = DateParseHandling.None,
//            Converters =
//            {
//                TypeEnumConverter.Singleton,
//                NameConverter.Singleton,
//                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
//            },
//        };
//    }
//
//    internal class TypeEnumConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);
//
//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            if (value == "Package")
//            {
//                return TypeEnum.Package;
//            }
//            throw new Exception("Cannot unmarshal type TypeEnum");
//        }
//
//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (TypeEnum)untypedValue;
//            if (value == TypeEnum.Package)
//            {
//                serializer.Serialize(writer, "Package");
//                return;
//            }
//            throw new Exception("Cannot marshal type TypeEnum");
//        }
//
//        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
//    }
//
//    internal class NameConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(Name) || t == typeof(Name?);
//
//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            if (value == "Dependency")
//            {
//                return Name.Dependency;
//            }
//            throw new Exception("Cannot unmarshal type Name");
//        }
//
//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (Name)untypedValue;
//            if (value == Name.Dependency)
//            {
//                serializer.Serialize(writer, "Dependency");
//                return;
//            }
//            throw new Exception("Cannot marshal type Name");
//        }
//
//        public static readonly NameConverter Singleton = new NameConverter();
//    }
}
