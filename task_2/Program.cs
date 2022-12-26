int rec(int n, int m)
{
    if (n == 0) 
        return m + 1;
    if (n != 0 && m == 0) 
        return rec(n - 1, 1);
    if (n > 0 && m > 0) 
        return rec(n - 1, rec(n, m - 1));
    return rec(n,m);
 }





Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n, m));
