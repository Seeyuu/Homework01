public class CovertMoney
{
    public void Convert(double money)
    {
        int total = (Int32)(money*100);
        
        int Thousand, FifH, OneH, Fifty, Twenty, Ten, Two, One,S50, S25;
       
        Thousand = total/100000 ;
        total %= 100000;

        FifH = total/50000;
        total %= 50000;

        OneH = total/10000;
        total %= 10000;

        Fifty = total/5000;
        total %= 5000;

        Twenty = total/2000;
        total %= 2000;

        Ten = total/1000;
        total %= 1000;

        Two = total/200;
        total %= 200;

        One = total/100;
        total %= 100;

        S50 = total/50;
        total %= 50;

        S25 = total/25;
        total %= 25;

        Console.WriteLine("1000 : {0}", Thousand);
        Console.WriteLine("500 : {0}", FifH);
        Console.WriteLine("100 : {0}", OneH);
        Console.WriteLine("50 : {0}", Fifty);
        Console.WriteLine("20 : {0}", Twenty);
        Console.WriteLine("10 : {0}", Ten);
        Console.WriteLine("2 : {0}", Two);
        Console.WriteLine("1 : {0}", One);
        Console.WriteLine("0.50 : {0}", S50);
        Console.WriteLine("0.25 : {0}", S25);
    }
}