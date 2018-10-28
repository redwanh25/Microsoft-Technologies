using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.IO;


class Input_neoya
{

    void solve()
    {
        int n = nextInt();
        int bobPos = nextInt();
        int[] a = new int[n];
        int[] b = new int[n];
        for (int i = 0; i < n; i++)
        {
            int x = nextInt();
            int y = nextInt();
            a[i] = Math.Min(x, y);
            b[i] = Math.Max(x, y);

        }
        int ret = int.MaxValue;
        for (int i = 0; i <= 1000; i++)
        {
            bool ok = true;
            for (int j = 0; j < n; j++)
                if (i < a[j] || i > b[j])
                    ok = false;
            if (ok)
                ret = Math.Min(ret, Math.Abs(bobPos - i));
        }
        if (ret == int.MaxValue)
            ret = -1;
        Console.WriteLine(ret);
    }


    //





    string[] inputLine = new string[0];
    int inputInd = 0;
    string nextLine()
    {
        return Console.ReadLine();
    }
    void readInput()
    {
        if (inputInd != inputLine.Length)
            throw new Exception();
        inputInd = 0;
        inputLine = Console.ReadLine().Split();

    }
    int nextInt()
    {
        if (inputInd == inputLine.Length)
            readInput();
        return int.Parse(inputLine[inputInd++]);
    }
    long nextLong()
    {
        if (inputInd == inputLine.Length)
            readInput();
        return long.Parse(inputLine[inputInd++]);
    }
    double nextDouble()
    {
        if (inputInd == inputLine.Length)
            readInput();
        return double.Parse(inputLine[inputInd++]);
    }
    string nextString()
    {
        if (inputInd == inputLine.Length)
            readInput();
        return inputLine[inputInd++];
    }
    static void Main(string[] args)
    {
        new Input_neoya().solve();
    }
}
