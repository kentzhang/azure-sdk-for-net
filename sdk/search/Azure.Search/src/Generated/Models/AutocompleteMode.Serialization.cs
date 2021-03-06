// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;

namespace Azure.Search.Models
{
    internal static class AutocompleteModeExtensions
    {
        public static string ToSerialString(this AutocompleteMode value) => value switch
        {
            AutocompleteMode.OneTerm => "oneTerm",
            AutocompleteMode.TwoTerms => "twoTerms",
            AutocompleteMode.OneTermWithContext => "oneTermWithContext",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutocompleteMode value.")
        };

        public static AutocompleteMode ToAutocompleteMode(this string value) => value switch
        {
            "oneTerm" => AutocompleteMode.OneTerm,
            "twoTerms" => AutocompleteMode.TwoTerms,
            "oneTermWithContext" => AutocompleteMode.OneTermWithContext,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutocompleteMode value.")
        };
    }
}
