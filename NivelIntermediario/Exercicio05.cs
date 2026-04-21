public class Fibonacci
{
    public static int chamadasNaive = 0;
    public static int chamadasMemo = 0;
    public int FibNaive(int n)
    {
        chamadasNaive++;
        if(n <= 1) return n;
        return FibNaive(n - 1) + FibNaive(n - 2);
    }

    public long FibMemo(int n, Dictionary<int, long> cache)
    {
        chamadasMemo++;
        if(cache.ContainsKey(n)) return cache[n];
        if(n <= 1) return n;

        cache[n] = FibMemo(n - 1, cache) + FibMemo(n - 2, cache);
        return cache[n];
    }
}