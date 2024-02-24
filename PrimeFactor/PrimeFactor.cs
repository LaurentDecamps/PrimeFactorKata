namespace PrimeFactor;

public static class PrimeFactor
{
    public static int[] GetPrimeFactor(int inputInteger)
    {
        var primeFactorsToReturn = new List<int>();
        if (inputInteger > 1)
        {
            primeFactorsToReturn.Add(2);
        }
        return primeFactorsToReturn.ToArray();
    }
}