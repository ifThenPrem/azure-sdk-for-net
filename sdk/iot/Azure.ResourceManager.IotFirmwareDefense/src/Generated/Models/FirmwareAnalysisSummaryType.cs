// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Describes the type of summary. </summary>
    internal readonly partial struct FirmwareAnalysisSummaryType : IEquatable<FirmwareAnalysisSummaryType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FirmwareAnalysisSummaryType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FirmwareAnalysisSummaryType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FirmwareValue = "Firmware";
        private const string CveValue = "CVE";
        private const string BinaryHardeningValue = "BinaryHardening";
        private const string CryptoCertificateValue = "CryptoCertificate";
        private const string CryptoKeyValue = "CryptoKey";

        /// <summary> Firmware. </summary>
        public static FirmwareAnalysisSummaryType Firmware { get; } = new FirmwareAnalysisSummaryType(FirmwareValue);
        /// <summary> CVE. </summary>
        public static FirmwareAnalysisSummaryType Cve { get; } = new FirmwareAnalysisSummaryType(CveValue);
        /// <summary> BinaryHardening. </summary>
        public static FirmwareAnalysisSummaryType BinaryHardening { get; } = new FirmwareAnalysisSummaryType(BinaryHardeningValue);
        /// <summary> CryptoCertificate. </summary>
        public static FirmwareAnalysisSummaryType CryptoCertificate { get; } = new FirmwareAnalysisSummaryType(CryptoCertificateValue);
        /// <summary> CryptoKey. </summary>
        public static FirmwareAnalysisSummaryType CryptoKey { get; } = new FirmwareAnalysisSummaryType(CryptoKeyValue);
        /// <summary> Determines if two <see cref="FirmwareAnalysisSummaryType"/> values are the same. </summary>
        public static bool operator ==(FirmwareAnalysisSummaryType left, FirmwareAnalysisSummaryType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FirmwareAnalysisSummaryType"/> values are not the same. </summary>
        public static bool operator !=(FirmwareAnalysisSummaryType left, FirmwareAnalysisSummaryType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FirmwareAnalysisSummaryType"/>. </summary>
        public static implicit operator FirmwareAnalysisSummaryType(string value) => new FirmwareAnalysisSummaryType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FirmwareAnalysisSummaryType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FirmwareAnalysisSummaryType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
