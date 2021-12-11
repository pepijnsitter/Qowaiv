﻿namespace MonthSpan_specs;

public class Is_equal_by_value
{
    [Test]
    public void not_equal_to_null()
        => Svo.MonthSpan.Equals(null).Should().BeFalse();

    [Test]
    public void not_equal_to_other_type()
        => Svo.MonthSpan.Equals(new object()).Should().BeFalse();

    [Test]
    public void not_equal_to_different_value()
        => Svo.MonthSpan.Equals(MonthSpan.MinValue).Should().BeFalse();

    [Test]
    public void equal_to_same_value()
        => Svo.MonthSpan.Equals(MonthSpan.FromMonths(69)).Should().BeTrue();

    [Test]
    public void equal_operator_returns_true_for_same_values()
        => (MonthSpan.FromMonths(69) == Svo.MonthSpan).Should().BeTrue();

    [Test]
    public void equal_operator_returns_false_for_different_values()
        => (MonthSpan.FromMonths(69) == MonthSpan.MinValue).Should().BeFalse();

    [Test]
    public void not_equal_operator_returns_false_for_same_values()
        => (MonthSpan.FromMonths(69) != Svo.MonthSpan).Should().BeFalse();

    [Test]
    public void not_equal_operator_returns_true_for_different_values()
        => (MonthSpan.FromMonths(69) != MonthSpan.MinValue).Should().BeTrue();

    [TestCase("0Y+0M", 0)]
    [TestCase("5Y+9M", 665630102)]
    public void hash_code_is_value_based(MonthSpan svo, int hash)
    {
        using (Hash.WithoutRandomizer())
        {
            svo.GetHashCode().Should().Be(hash);
        }
    }
}

public class Supports_type_conversion
{
    [Test]
    public void via_TypeConverter_registered_with_attribute()
        => typeof(MonthSpan).Should().HaveTypeConverterDefined();

    [Test]
    public void from_null_string()
    {
        using (TestCultures.En_GB.Scoped())
        {
            Converting.From<string>(null).To<MonthSpan>().Should().Be(MonthSpan.Zero);
        }
    }

    [Test]
    public void from_empty_string()
    {
        using (TestCultures.En_GB.Scoped())
        {
            Converting.From(string.Empty).To<MonthSpan>().Should().Be(MonthSpan.Zero);
        }
    }

    [Test]
    public void from_string()
    {
        using (TestCultures.En_GB.Scoped())
        {
            Converting.From("5Y+9M").To<MonthSpan>().Should().Be(Svo.MonthSpan);
        }
    }

    [Test]
    public void to_string()
    {
        using (TestCultures.En_GB.Scoped())
        {
            Converting.ToString().From(Svo.MonthSpan).Should().Be("5Y+9M");
        }
    }

    [Test]
    public void from_int()
        => Converting.From(69).To<MonthSpan>().Should().Be(Svo.MonthSpan);

    [Test]
    public void to_int()
        => Converting.To<int>().From(Svo.MonthSpan).Should().Be(69);
}