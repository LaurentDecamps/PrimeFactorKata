namespace PrimeFactor;

public static class PrimeFactor
{
    public static int[] GetPrimeFactor(int inputInteger)
    {
        var primeFactorsToReturn = new List<int>();
        for (int index = 2; index <= inputInteger; index++)
        {
            if (inputInteger % index != 0) continue;
            primeFactorsToReturn.Add(index);
            inputInteger /= index;
            index = 1;
        }
        
        return primeFactorsToReturn.ToArray();
    }
}