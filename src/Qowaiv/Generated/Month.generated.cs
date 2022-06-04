﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
#nullable enable

namespace Qowaiv;

public partial struct Month
{
    private Month(byte value) => m_Value = value;

    /// <summary>The inner value of the month.</summary>
    private readonly byte m_Value;

    /// <summary>Returns true if the month is empty, otherwise false.</summary>
    [Pure]
    public bool IsEmpty() => m_Value == default;
    /// <summary>Returns true if the month is unknown, otherwise false.</summary>
    [Pure]
    public bool IsUnknown() => m_Value == Unknown.m_Value;
    /// <summary>Returns true if the month is empty or unknown, otherwise false.</summary>
    [Pure]
    public bool IsEmptyOrUnknown() => IsEmpty() || IsUnknown();
}

public partial struct Month : IEquatable<Month>
{
    /// <inheritdoc />
    [Pure]
    public override bool Equals(object? obj) => obj is Month other && Equals(other);

    /// <summary>Returns true if this instance and the other month are equal, otherwise false.</summary>
    /// <param name="other">The <see cref="Month" /> to compare with.</param>
    [Pure]
    public bool Equals(Month other) => m_Value == other.m_Value;

    /// <inheritdoc />
    [Pure]
    public override int GetHashCode() => Hash.Code(m_Value);

    /// <summary>Returns true if the left and right operand are equal, otherwise false.</summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand</param>
    public static bool operator ==(Month left, Month right) => left.Equals(right);

    /// <summary>Returns true if the left and right operand are not equal, otherwise false.</summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand</param>
    public static bool operator !=(Month left, Month right) => !(left == right);
}

public partial struct Month : IComparable, IComparable<Month>
{
    /// <inheritdoc />
    [Pure]
    public int CompareTo(object? obj)
    {
        if (obj is null) { return 1; }
        else if (obj is Month other) { return CompareTo(other); }
        else { throw new ArgumentException($"Argument must be {GetType().Name}.", nameof(obj)); }
    }
    /// <inheritdoc />
    [Pure]
#nullable disable
    public int CompareTo(Month other) => Comparer<byte>.Default.Compare(m_Value, other.m_Value);
#nullable enable
}

public partial struct Month : IFormattable
{
    /// <summary>Returns a <see cref="string"/> that represents the month.</summary>
    [Pure]
    public override string ToString() => ToString(provider: null);

    /// <summary>Returns a formatted <see cref="string"/> that represents the month.</summary>
    /// <param name="format">
    /// The format that describes the formatting.
    /// </param>
    [Pure]
    public string ToString(string? format) => ToString(format, formatProvider: null);

    /// <summary>Returns a formatted <see cref="string"/> that represents the month.</summary>
    /// <param name="provider">
    /// The format provider.
    /// </param>
    [Pure]
    public string ToString(IFormatProvider? provider) => ToString(format: null, provider);
}

public partial struct Month : ISerializable
{
    /// <summary>Initializes a new instance of the month based on the serialization info.</summary>
    /// <param name="info">The serialization info.</param>
    /// <param name="context">The streaming context.</param>
    private Month(SerializationInfo info, StreamingContext context)
    {
        Guard.NotNull(info, nameof(info));
        m_Value = info.GetValue("Value", typeof(byte)) is byte val ? val : default(byte);
    }

    /// <summary>Adds the underlying property of the month to the serialization info.</summary>
    /// <param name="info">The serialization info.</param>
    /// <param name="context">The streaming context.</param>
    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        => Guard.NotNull(info, nameof(info)).AddValue("Value", m_Value);
}

public partial struct Month
{
    /// <summary>Creates the month from a JSON string.</summary>
    /// <param name="json">
    /// The JSON string to deserialize.
    /// </param>
    /// <returns>
    /// The deserialized month.
    /// </returns>
    [Pure]
    public static Month FromJson(string? json) => Parse(json, CultureInfo.InvariantCulture);
}

public partial struct Month : IXmlSerializable
{
    /// <summary>Gets the <see href="XmlSchema" /> to XML (de)serialize the month.</summary>
    /// <remarks>
    /// Returns null as no schema is required.
    /// </remarks>
    [Pure]
    XmlSchema? IXmlSerializable.GetSchema() => (XmlSchema?)null;

    /// <summary>Reads the month from an <see href="XmlReader" />.</summary>
    /// <param name="reader">An XML reader.</param>
    void IXmlSerializable.ReadXml(XmlReader reader)
    {
        Guard.NotNull(reader, nameof(reader));
        var xml = reader.ReadElementString();
        System.Runtime.CompilerServices.Unsafe.AsRef(this) = Parse(xml, CultureInfo.InvariantCulture);
    }

    /// <summary>Writes the month to an <see href="XmlWriter" />.</summary>
    /// <remarks>
    /// Uses <see cref="ToXmlString()"/>.
    /// </remarks>
    /// <param name="writer">An XML writer.</param>
    void IXmlSerializable.WriteXml(XmlWriter writer)
        => Guard.NotNull(writer, nameof(writer)).WriteString(ToXmlString());
}

public partial struct Month
{
    /// <summary>Converts the <see cref="string"/> to <see cref="Month"/>.</summary>
    /// <param name="s">
    /// A string containing the month to convert.
    /// </param>
    /// <returns>
    /// The parsed month.
    /// </returns>
    /// <exception cref="FormatException">
    /// <paramref name="s"/> is not in the correct format.
    /// </exception>
    [Pure]
    public static Month Parse(string? s) => Parse(s, null);

    /// <summary>Converts the <see cref="string"/> to <see cref="Month"/>.</summary>
    /// <param name="s">
    /// A string containing the month to convert.
    /// </param>
    /// <param name="formatProvider">
    /// The specified format provider.
    /// </param>
    /// <returns>
    /// The parsed month.
    /// </returns>
    /// <exception cref="FormatException">
    /// <paramref name="s"/> is not in the correct format.
    /// </exception>
    [Pure]
    public static Month Parse(string? s, IFormatProvider? formatProvider) => TryParse(s, formatProvider) ?? throw new FormatException(QowaivMessages.FormatExceptionMonth);

    /// <summary>Converts the <see cref="string"/> to <see cref="Month"/>.</summary>
    /// <param name="s">
    /// A string containing the month to convert.
    /// </param>
    /// <returns>
    /// The month if the string was converted successfully, otherwise default.
    /// </returns>
    [Pure]
    public static Month? TryParse(string? s) => TryParse(s, null);

    /// <summary>Converts the <see cref="string"/> to <see cref="Month"/>.</summary>
    /// <param name="s">
    /// A string containing the month to convert.
    /// </param>
    /// <param name="formatProvider">
    /// The specified format provider.
    /// </param>
    /// <returns>
    /// The month if the string was converted successfully, otherwise default.
    /// </returns>
    [Pure]
    public static Month? TryParse(string? s, IFormatProvider? formatProvider) => TryParse(s, formatProvider, out var val) ? val : default(Month?);

    /// <summary>Converts the <see cref="string"/> to <see cref="Month"/>.
    /// A return value indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="s">
    /// A string containing the month to convert.
    /// </param>
    /// <param name="result">
    /// The result of the parsing.
    /// </param>
    /// <returns>
    /// True if the string was converted successfully, otherwise false.
    /// </returns>
    [Pure]
    public static bool TryParse(string? s, out Month result) => TryParse(s, null, out result);
}

public partial struct Month
{
    /// <summary>Returns true if the value represents a valid month.</summary>
    /// <param name="val">
    /// The <see cref="string"/> to validate.
    /// </param>
    [Pure]
    public static bool IsValid(string? val) => IsValid(val, (IFormatProvider?)null);

    /// <summary>Returns true if the value represents a valid month.</summary>
    /// <param name="val">
    /// The <see cref="string"/> to validate.
    /// </param>
    /// <param name="formatProvider">
    /// The <see cref="IFormatProvider"/> to interpret the <see cref="string"/> value with.
    /// </param>
    [Pure]
    public static bool IsValid(string? val, IFormatProvider? formatProvider)
        => !string.IsNullOrWhiteSpace(val)
        && TryParse(val, formatProvider, out _);
}

