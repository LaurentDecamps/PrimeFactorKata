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
}