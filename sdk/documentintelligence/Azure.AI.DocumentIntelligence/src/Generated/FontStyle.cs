// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Font style. </summary>
    public readonly partial struct FontStyle : IEquatable<FontStyle>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FontStyle"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FontStyle(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NormalValue = "normal";
        private const string ItalicValue = "italic";

        /// <summary> Characters are represented normally. </summary>
        public static FontStyle Normal { get; } = new FontStyle(NormalValue);
        /// <summary> Characters are visually slanted to the right. </summary>
        public static FontStyle Italic { get; } = new FontStyle(ItalicValue);
        /// <summary> Determines if two <see cref="FontStyle"/> values are the same. </summary>
        public static bool operator ==(FontStyle left, FontStyle right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FontStyle"/> values are not the same. </summary>
        public static bool operator !=(FontStyle left, FontStyle right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FontStyle"/>. </summary>
        public static implicit operator FontStyle(string value) => new FontStyle(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FontStyle other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FontStyle other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
