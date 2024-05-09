// See https://aka.ms/new-console-template for more information
using Bai3;
using System;

public class Program
{
    public static int Main(string[] args)
    {
        Caculator caculator = new Caculator(3,7);
        int resultCong = caculator.Cong();
        int resultTru = caculator.Tru();
        int resultNhan = caculator.Nhan();
        int resultChia = caculator.Chia();
        Console.WriteLine("Cong: "+ resultCong);
        Console.WriteLine("Tru: " + resultTru);
        Console.WriteLine("Nhan: " + resultNhan);
        Console.WriteLine("Chia: " + resultChia);
        return 0;
    }
}
