public class FatorialRecursivo
{
    public long Fatorial(int N)
    {
        if(N <= 1)
        {
            return 1;
        }
        
        return N * Fatorial(N - 1);
    }
}