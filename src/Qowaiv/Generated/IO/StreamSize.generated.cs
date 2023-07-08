﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

namespace Qowaiv.IO;

public partial struct StreamSize : IEquatable<StreamSize>
#if NET7_0_OR_GREATER
    , IEqualityOperators<StreamSize, StreamSize, bool>
#endif
{
    /// <inheritdoc />
    [Pure]
    public override bool Equals(object? obj) => obj is StreamSize other && Equals(other);

    /// <summary>Returns true if this instance and the other stream size are equal, otherwise false.</summary>
    /// <param name="other">The <see cref="StreamSize" /> to compare with.</param>
    [Pure]
    public bool Equals(StreamSize other) => m_Value == other.m_Value;

    /// <inheritdoc />
    [Pure]
    public override int GetHashCode() => Hash.Code(m_Value);

    /// <summary>Returns true if the left and right operand are equal, otherwise false.</summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand</param>
    public static bool operator ==(StreamSize left, StreamSize right) => left.Equals(right);

    /// <summary>Returns true if the left and right operand are not equal, otherwise false.</summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand</param>
    public static bool operator !=(StreamSize left, StreamSize right) => !(left == right);
}

public partial struct StreamSize : IComparable, IComparable<StreamSize>
#if NET7_0_OR_GREATER
    , IComparisonOperators<StreamSize, StreamSize, bool>
#endif
{
    /// <inheritdoc />
    [Pure]
    public int CompareTo(object? obj)
    {
        if (obj is null) { return 1; }
        else if (obj is StreamSize other) { return CompareTo(other); }
        else { throw new ArgumentException($"Argument must be {GetType().Name}.", nameof(obj)); }
    }
    /// <inheritdoc />
    [Pure]
#nullable disable
    public int CompareTo(StreamSize other) => Comparer<long>.Default.Compare(m_Value, other.m_Value);
#nullable enable
    /// <summary>Returns true if the left operator is less then the right operator, otherwise false.</summary>
    public static bool operator <(StreamSize l, StreamSize r) => l.CompareTo(r) < 0;

    /// <summary>Returns true if the left operator is greater then the right operator, otherwise false.</summary>
    public static bool operator >(StreamSize l, StreamSize r) => l.CompareTo(r) > 0;

    /// <summary>Returns true if the left operator is less then or equal the right operator, otherwise false.</summary>
    public static bool operator <=(StreamSize l, StreamSize r) => l.CompareTo(r) <= 0;

    /// <summary>Returns true if the left operator is greater then or equal the right operator, otherwise false.</summary>
    public static bool operator >=(StreamSize l, StreamSize r) => l.CompareTo(r) >= 0;
}

public partial struct StreamSize : ISerializable
{
    /// <summary>Initializes a new instance of the stream size based on the serialization info.</summary>
    /// <param name="info">The serialization info.</param>
    /// <param name="context">The streaming context.</param>
    private StreamSize(SerializationInfo info, StreamingContext context)
    {
        Guard.NotNull(info);
        m_Value = info.GetValue("Value", typeof(long)) is long val ? val : default(long);
    }

    /// <summary>Adds the underlying property of the stream size to the serialization info.</summary>
    /// <param name="info">The serialization info.</param>
    /// <param name="context">The streaming context.</param>
    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        => Guard.NotNull(info).AddValue("Value", m_Value);
}

public partial struct StreamSize
{
    /// <summary>Creates the stream size from a JSON string.</summary>
    /// <param name="json">
    /// The JSON string to deserialize.
    /// </param>
    /// <returns>
    /// The deserialized stream size.
    /// </returns>
    [Pure]
    public static StreamSize FromJson(string? json) => Parse(json, CultureInfo.InvariantCulture);
}

public partial struct StreamSize : IXmlSerializable
{
    /// <summary>Gets the <see href="XmlSchema" /> to XML (de)serialize the stream size.</summary>
    /// <remarks>
    /// Returns null as no schema is required.
    /// </remarks>
    [Pure]
    XmlSchema? IXmlSerializable.GetSchema() => (XmlSchema?)null;

    /// <summary>Reads the stream size from an <see href="XmlReader" />.</summary>
    /// <param name="reader">An XML reader.</param>
    void IXmlSerializable.ReadXml(XmlReader reader)
    {
        Guard.NotNull(reader);
        var xml = reader.ReadElementString();
        System.Runtime.CompilerServices.Unsafe.AsRef(this) = Parse(xml, CultureInfo.InvariantCulture);
    }

    /// <summary>Writes the stream size to an <see href="XmlWriter" />.</summary>
    /// <remarks>
    /// Uses <see cref="ToXmlString()"/>.
    /// </remarks>
    /// <param name="writer">An XML writer.</param>
    void IXmlSerializable.WriteXml(XmlWriter writer)
        => Guard.NotNull(writer).WriteString(ToXmlString());
}

public partial struct StreamSize
#if NET7_0_OR_GREATER
    : IParsable<StreamSize>
#endif
{
    /// <summary>Converts the <see cref="string"/> to <see cref="StreamSize"/>.</summary>
    /// <param name="s">
    /// A string containing the stream size to convert.
    /// </param>
    /// <returns>
    /// The parsed stream size.
    /// </returns>
    /// <exception cref="FormatException">
    /// <paramref name="s"/> is not in the correct format.
    /// </exception>
    [Pure]
    public static StreamSize Parse(string? s) => Parse(s, null);

    /// <summary>Converts the <see cref="string"/> to <see cref="StreamSize"/>.</summary>
    /// <param name="s">
    /// A string containing the stream size to convert.
    /// </param>
    /// <param name="formatProvider">
    /// The specified format provider.
    /// </param>
    /// <returns>
    /// The parsed stream size.
    /// </returns>
    /// <exception cref="FormatException">
    /// <paramref name="s"/> is not in the correct format.
    /// </exception>
    [Pure]
    public static StreamSize Parse(string? s, IFormatProvider? formatProvider) => TryParse(s, formatProvider) ?? throw new FormatException(QowaivMessages.FormatExceptionStreamSize);

    /// <summary>Converts the <see cref="string"/> to <see cref="StreamSize"/>.</summary>
    /// <param name="s">
    /// A string containing the stream size to convert.
    /// </param>
    /// <returns>
    /// The stream size if the string was converted successfully, otherwise default.
    /// </returns>
    [Pure]
    public static StreamSize? TryParse(string? s) => TryParse(s, null);

    /// <summary>Converts the <see cref="string"/> to <see cref="StreamSize"/>.</summary>
    /// <param name="s">
    /// A string containing the stream size to convert.
    /// </param>
    /// <param name="formatProvider">
    /// The specified format provider.
    /// </param>
    /// <returns>
    /// The stream size if the string was converted successfully, otherwise default.
    /// </returns>
    [Pure]
    public static StreamSize? TryParse(string? s, IFormatProvider? formatProvider) => TryParse(s, formatProvider, out var val) ? val : default(StreamSize?);

    /// <summary>Converts the <see cref="string"/> to <see cref="StreamSize"/>.
    /// A return value indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="s">
    /// A string containing the stream size to convert.
    /// </param>
    /// <param name="result">
    /// The result of the parsing.
    /// </param>
    /// <returns>
    /// True if the string was converted successfully, otherwise false.
    /// </returns>
    [Impure]
    public static bool TryParse(string? s, out StreamSize result) => TryParse(s, null, out result);
}

public partial struct StreamSize
{
    /// <summary>Returns true if the value represents a valid stream size.</summary>
    /// <param name="val">
    /// The <see cref="string"/> to validate.
    /// </param>
    [Pure]
    [ExcludeFromCodeCoverage]
    [Obsolete("Use StreamSize.TryParse(str) is { } instead. Will be dropped when the next major version is released.")]
    public static bool IsValid(string? val) => IsValid(val, (IFormatProvider?)null);

    /// <summary>Returns true if the value represents a valid stream size.</summary>
    /// <param name="val">
    /// The <see cref="string"/> to validate.
    /// </param>
    /// <param name="formatProvider">
    /// The <see cref="IFormatProvider"/> to interpret the <see cref="string"/> value with.
    /// </param>
    [Pure]
    [ExcludeFromCodeCoverage]
    [Obsolete("Use StreamSize.TryParse(str, formatProvider) is { } instead. Will be dropped when the next major version is released.")]
    public static bool IsValid(string? val, IFormatProvider? formatProvider)
        => !string.IsNullOrWhiteSpace(val)
        && TryParse(val, formatProvider, out _);
}
