int rec(int n, int m)
{
    
    if ( m == n )
        return n;
    return rec(n + 1, m) + n;
}





Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n, m));
