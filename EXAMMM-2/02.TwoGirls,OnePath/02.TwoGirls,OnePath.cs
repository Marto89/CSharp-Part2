using System;

class TwoGirlsOnePath
{
    static void Main()
    {
        string[] pathCells = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        long [] realPath=new long[pathCells.Length];
        for (int i = 0; i < pathCells.Length; i++)
        {
            realPath[i] = long.Parse(pathCells[i]);
        }
        long dollyPath = realPath.Length-1;
        Console.WriteLine("Dolly");
        Console.WriteLine("{0} {1}",0,0);
    }
}