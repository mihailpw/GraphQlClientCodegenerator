﻿using System.Collections.Generic;

namespace GQLCCG.Processor.SchemaReaders
{
    internal class GraphQlJsonDto
    {
        public const string RetrieveSchemaQuery = @"query IntrospectionQuery { __schema { queryType { name } mutationType { name } subscriptionType { name } types { ...FullType } } } fragment ShortType on __Type { kind name ofType { kind name ofType { kind name ofType { kind name } } } } fragment FullType on __Type { kind name description fields(includeDeprecated: true) { ...Field } inputFields { ...InputValue } interfaces { ...ShortType } enumValues(includeDeprecated: true) { ...EnumValue } possibleTypes { ...ShortType } } fragment Field on __Field { name description args { ...InputValue } type { ...ShortType } isDeprecated deprecationReason } fragment InputValue on __InputValue { name description type { ...ShortType } defaultValue } fragment EnumValue on __EnumValue { name description isDeprecated deprecationReason }";



        public class Schema
        {
            public ShortType QueryType { get; set; }
            public ShortType MutationType { get; set; }
            public ShortType SubscriptionType { get; set; }
            public List<FullType> Types { get; set; }
        }

        public class ShortType
        {
            public string Kind { get; set; }
            public string Name { get; set; }
            public ShortType OfType { get; set; }
        }

        public class FullType
        {
            public string Kind { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public List<Field> Fields { get; set; }
            public List<InputValue> InputFields { get; set; }
            public List<ShortType> Interfaces { get; set; }
            public List<EnumValue> EnumValues { get; set; }
            public List<ShortType> PossibleTypes { get; set; }
        }

        public class Field
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public List<InputValue> Args { get; set; }
            public ShortType Type { get; set; }
            public bool IsDeprecated { get; set; }
            public string DeprecationReason { get; set; }
        }

        public class InputValue
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public ShortType Type { get; set; }
            public string DefaultValue { get; set; }
        }

        public class EnumValue
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public bool IsDeprecated { get; set; }
            public string DeprecationReason { get; set; }
        }
    }
}