using System;

class Program
{
    // deklaracija clanova klase
    public static int i;
    public int j;
    
    // deklaracija metoda klase
    public void prikazi()
    {
        Console.WriteLine("i={0} j={1}", i, j);

    }
}
class prog1
{
    public static void Main()
    {
        Program rc1 = new Program();
        rc1.j = 1;
        Program rc2 = new Program();
        rc2.j = 2;
        Program.i = 3;

        rc1.prikazi();
        rc2.prikazi();
    }
}