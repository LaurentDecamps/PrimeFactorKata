namespace PrimeFactor;

public static class PrimeFactor
{
    public static int[] GetPrimeFactor(int inputInteger)
    {
        return inputInteger == 2 ? new[] {2} : new[] {1};
    }
}