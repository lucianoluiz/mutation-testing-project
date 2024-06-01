using FluentAssertions;
using Insurance;

namespace InsuranceTests;

public class CarInsuranceTest
{
    private readonly CarInsurance _insurance = new();

    [Theory]
    [InlineData(25)]
    [InlineData(45)]
    [InlineData(33)]
    [InlineData(50)]
    [InlineData(69)]
    public void Should_Allow_Insurance_Successful_FluentAssertions(int age)
    {
        var result = _insurance.Risk(age);
        result.Should().BeTrue();
    }

    [Theory]
    [InlineData(25)]
    [InlineData(45)]
    [InlineData(33)]
    [InlineData(50)]
    [InlineData(69)]
    public void Should_Allow_Insurance_Successful_XUnit(int age)
    {
        var result = _insurance.Risk(age);
        Assert.True(result);
    }

    [Theory]
    [InlineData(71)]
    [InlineData(80)]
    [InlineData(70)]
    [InlineData(20)]
    [InlineData(24)]
    public void Should_Not_Allow_Insurance_Successful_FluentAssertions(int age)
    {
        var result = _insurance.Risk(age);
        result.Should().BeFalse();
    }

    [Theory]
    [InlineData(71)]
    [InlineData(80)]
    [InlineData(70)]
    [InlineData(20)]
    [InlineData(24)]
    public void Should_Not_Allow_Insurance_Successful_XUnit(int age)
    {
        var result = _insurance.Risk(age);
        Assert.False(result);
    }
}