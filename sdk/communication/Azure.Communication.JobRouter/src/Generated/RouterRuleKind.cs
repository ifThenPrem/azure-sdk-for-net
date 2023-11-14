// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.JobRouter
{
    /// <summary> Supported router rule types. </summary>
    public readonly partial struct RouterRuleKind : IEquatable<RouterRuleKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RouterRuleKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RouterRuleKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DirectMapValue = "directMap";
        private const string ExpressionValue = "expression";
        private const string FunctionValue = "function";
        private const string StaticValue = "static";
        private const string WebhookValue = "webhook";

        /// <summary> Discriminator value for DirectMapRouterRule. </summary>
        public static RouterRuleKind DirectMap { get; } = new RouterRuleKind(DirectMapValue);
        /// <summary> Discriminator value for ExpressionRouterRule. </summary>
        public static RouterRuleKind Expression { get; } = new RouterRuleKind(ExpressionValue);
        /// <summary> Discriminator value for FunctionRouterRule. </summary>
        public static RouterRuleKind Function { get; } = new RouterRuleKind(FunctionValue);
        /// <summary> Discriminator value for StaticRouterRule. </summary>
        public static RouterRuleKind Static { get; } = new RouterRuleKind(StaticValue);
        /// <summary> Discriminator value for WebhookRouterRule. </summary>
        public static RouterRuleKind Webhook { get; } = new RouterRuleKind(WebhookValue);
        /// <summary> Determines if two <see cref="RouterRuleKind"/> values are the same. </summary>
        public static bool operator ==(RouterRuleKind left, RouterRuleKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RouterRuleKind"/> values are not the same. </summary>
        public static bool operator !=(RouterRuleKind left, RouterRuleKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RouterRuleKind"/>. </summary>
        public static implicit operator RouterRuleKind(string value) => new RouterRuleKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RouterRuleKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RouterRuleKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
