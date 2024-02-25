using FluentAssertions;

using static PrimeFactor.PrimeFactor;

namespace PrimeFactorTest;

[TestFixture]
public class PrimeFactorTest
{
    private int[] GetArrayInitiateWith(params int[] values)
    {
        return values;
    }

    [Test]
    public void Should_Return_One_For_Input_One()
    {
        var onePrimeFactors = GetPrimeFactor(1);
        onePrimeFactors.Should().BeEquivalentTo(GetArrayInitiateWith());
    }

    [Test]
    public void Should_Return_Two_For_Input_Two()
    {
        var twoPrimeFactors = GetPrimeFactor(2);
        twoPrimeFactors.Should().BeEquivalentTo(GetArrayInitiateWith(2));
    }

    [Test]
    public void Should_Return_Three_For_Input_Three()
    {
        var twoPrimeFactors = GetPrimeFactor(3);
        twoPrimeFactors.Should().BeEquivalentTo(GetArrayInitiateWith(3));
    }

    [Test]
    public void Should_Return_Three_For_Input_Four()
    {
        var twoPrimeFactors = GetPrimeFactor(4);
        twoPrimeFactors.Should().BeEquivalentTo(GetArrayInitiateWith(2,2));
    }

    [Test]
    public void Should_Return_Three_For_Input_Nine()
    {
        var twoPrimeFactors = GetPrimeFactor(9);
        twoPrimeFactors.Should().BeEquivalentTo(GetArrayInitiateWith(3,3));
    }
}