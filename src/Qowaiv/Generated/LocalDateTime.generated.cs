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

public partial struct LocalDateTime : IEquatable<LocalDateTime>
{
    /// <inheritdoc />
    [Pure]
    public override bool Equals(object? obj) => obj is LocalDateTime other && Equals(other);

    /// <summary>Returns true if this instance and the other local date time are equal, otherwise false.</summary>
    /// <param name="other">The <see cref="LocalDateTime" /> to compare with.</param>
    [Pure]
    public bool Equals(LocalDateTime other) => m_Value == other.m_Value;

    /// <inheritdoc />
    [Pure]
    public override int GetHashCode() => Hash.Code(m_Value);

    /// <summary>Returns true if the left and right operand are equal, otherwise false.</summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand</param>
    public static bool operator ==(LocalDateTime left, LocalDateTime right) => left.Equals(right);

    /// <summary>Returns true if the left and right operand are not equal, otherwise false.</summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand</param>
    public static bool operator !=(LocalDateTime left, LocalDateTime right) => !(left == right);
}

public partial struct LocalDateTime : IComparable, IComparable<LocalDateTime>
{
    /// <inheritdoc />
    [Pure]
    public int CompareTo(object? obj)
    {
        if (obj is null) { return 1; }
        else if (obj is LocalDateTime other) { return CompareTo(other); }
        else { throw new ArgumentException($"Argument must be {GetType().Name}.", nameof(obj)); }
    }
    /// <inheritdoc />
    [Pure]
#nullable disable
    public int CompareTo(LocalDateTime other) => Comparer<DateTime>.Default.Compare(m_Value, other.m_Value);
#nullable enable
    /// <summary>Returns true if the left operator is less then the right operator, otherwise false.</summary>
    public static bool operator <(LocalDateTime l, LocalDateTime r) => l.CompareTo(r) < 0;

    /// <summary>Returns true if the left operator is greater then the right operator, otherwise false.</summary>
    public static bool operator >(LocalDateTime l, LocalDateTime r) => l.CompareTo(r) > 0;

    /// <summary>Returns true if the left operator is less then or equal the right operator, otherwise false.</summary>
    public static bool operator <=(LocalDateTime l, LocalDateTime r) => l.CompareTo(r) <= 0;

    /// <summary>Returns true if the left operator is greater then or equal the right operator, otherwise false.</summary>
    public static bool operator >=(LocalDateTime l, LocalDateTime r) => l.CompareTo(r) >= 0;
}

public partial struct LocalDateTime : IFormattable
{
    /// <summary>Returns a <see cref="string"/> that represents the local date time.</summary>
    [Pure]
    public override string ToString() => ToString(provider: null);

    /// <summary>Returns a formatted <see cref="string"/> that represents the local date time.</summary>
    /// <param name="format">
    /// The format that describes the formatting.
    /// </param>
    [Pure]
    public string ToString(string? format) => ToString(format, formatProvider: null);

    /// <summary>Returns a formatted <see cref="string"/> that represents the local date time.</summary>
    /// <param name="provider">
    /// The format provider.
    /// </param>
    [Pure]
    public string ToString(IFormatProvider? provider) => ToString(format: null, provider);
}

public partial struct LocalDateTime : ISerializable
{
    /// <summary>Initializes a new instance of the local date time based on the serialization info.</summary>
    /// <param name="info">The serialization info.</param>
    /// <param name="context">The streaming context.</param>
    private LocalDateTime(SerializationInfo info, StreamingContext context)
    {
        Guard.NotNull(info, nameof(info));
        m_Value = info.GetValue("Value", typeof(DateTime)) is DateTime val ? val : default(DateTime);
    }

    /// <summary>Adds the underlying property of the local date time to the serialization info.</summary>
    /// <param name="info">The serialization info.</param>
    /// <param name="context">The streaming context.</param>
    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        => Guard.NotNull(info, nameof(info)).AddValue("Value", m_Value);
}

public partial struct LocalDateTime
{
    /// <summary>Creates the local date time from a JSON string.</summary>
    /// <param name="json">
    /// The JSON string to deserialize.
    /// </param>
    /// <returns>
    /// The deserialized local date time.
    /// </returns>
    [Pure]
    public static LocalDateTime FromJson(string? json) => Parse(json, CultureInfo.InvariantCulture);
}

public partial struct LocalDateTime : IXmlSerializable
{
    /// <summary>Gets the <see href="XmlSchema" /> to XML (de)serialize the local date time.</summary>
    /// <remarks>
    /// Returns null as no schema is required.
    /// </remarks>
    [Pure]
    XmlSchema? IXmlSerializable.GetSchema() => (XmlSchema?)null;

    /// <summary>Reads the local date time from an <see href="XmlReader" />.</summary>
    /// <param name="reader">An XML reader.</param>
    void IXmlSerializable.ReadXml(XmlReader reader)
    {
        Guard.NotNull(reader, nameof(reader));
        var xml = reader.ReadElementString();
        System.Runtime.CompilerServices.Unsafe.AsRef(this) = Parse(xml, CultureInfo.InvariantCulture);
    }

    /// <summary>Writes the local date time to an <see href="XmlWriter" />.</summary>
    /// <remarks>
    /// Uses <see cref="ToXmlString()"/>.
    /// </remarks>
    /// <param name="writer">An XML writer.</param>
    void IXmlSerializable.WriteXml(XmlWriter writer)
        => Guard.NotNull(writer, nameof(writer)).WriteString(ToXmlString());
}

public partial struct LocalDateTime
{
    /// <summary>Converts the <see cref="string"/> to <see cref="LocalDateTime"/>.</summary>
    /// <param name="s">
    /// A string containing the local date time to convert.
    /// </param>
    /// <returns>
    /// The parsed local date time.
    /// </returns>
    /// <exception cref="FormatException">
    /// <paramref name="s"/> is not in the correct format.
    /// </exception>
    [Pure]
    public static LocalDateTime Parse(string? s) => Parse(s, null);

    /// <summary>Converts the <see cref="string"/> to <see cref="LocalDateTime"/>.</summary>
    /// <param name="s">
    /// A string containing the local date time to convert.
    /// </param>
    /// <param name="formatProvider">
    /// The specified format provider.
    /// </param>
    /// <returns>
    /// The parsed local date time.
    /// </returns>
    /// <exception cref="FormatException">
    /// <paramref name="s"/> is not in the correct format.
    /// </exception>
    [Pure]
    public static LocalDateTime Parse(string? s, IFormatProvider? formatProvider) => TryParse(s, formatProvider) ?? throw new FormatException(QowaivMessages.FormatExceptionLocalDateTime);

    /// <summary>Converts the <see cref="string"/> to <see cref="LocalDateTime"/>.</summary>
    /// <param name="s">
    /// A string containing the local date time to convert.
    /// </param>
    /// <returns>
    /// The local date time if the string was converted successfully, otherwise default.
    /// </returns>
    [Pure]
    public static LocalDateTime? TryParse(string? s) => TryParse(s, null);

    /// <summary>Converts the <see cref="string"/> to <see cref="LocalDateTime"/>.</summary>
    /// <param name="s">
    /// A string containing the local date time to convert.
    /// </param>
    /// <param name="formatProvider">
    /// The specified format provider.
    /// </param>
    /// <returns>
    /// The local date time if the string was converted successfully, otherwise default.
    /// </returns>
    [Pure]
    public static LocalDateTime? TryParse(string? s, IFormatProvider? formatProvider) => TryParse(s, formatProvider, out var val) ? val : default(LocalDateTime?);

    /// <summary>Converts the <see cref="string"/> to <see cref="LocalDateTime"/>.
    /// A return value indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="s">
    /// A string containing the local date time to convert.
    /// </param>
    /// <param name="result">
    /// The result of the parsing.
    /// </param>
    /// <returns>
    /// True if the string was converted successfully, otherwise false.
    /// </returns>
    [Pure]
    public static bool TryParse(string? s, out LocalDateTime result) => TryParse(s, null, out result);
}

public partial struct LocalDateTime
{

    /// <summary>Returns true if the value represents a valid local date time.</summary>
    /// <param name="val">
    /// The <see cref="string"/> to validate.
    /// </param>
    [Pure]
    public static bool IsValid(string? val) => IsValid(val, (IFormatProvider?)null);

    /// <summary>Returns true if the value represents a valid local date time.</summary>
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

