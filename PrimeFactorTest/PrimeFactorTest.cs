namespace PrimeFactorTest;

[TestFixture]
public class PrimeFactorTest
{
    [Test]
    public void Should_Return_One_For_Input_One()
    {
        Assert.That(PrimeFactor.PrimeFactor.GetPrimeFactor(1), Is.EqualTo(new int[] {1}));
    }

    [Test]
    public void Should_Return_Two_For_Input_Two()
    {
        Assert.That(PrimeFactor.PrimeFactor.GetPrimeFactor(2), Is.EqualTo(new int[] {2}));
    }
}