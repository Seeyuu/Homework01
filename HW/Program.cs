public class Program
{
    public static string InputName()
    {
        Console.Write("Please Input Name : ");
        return Console.ReadLine();
    }
    public static double InputNumber()
    {
        Console.Write("Please Input Number : ");
        return double.Parse(Console.ReadLine());
    }
    public static string InputOwnerName()
    {
        Console.Write("Please Input Owner Name : ");
        return Console.ReadLine();
    }
    public static double InputValue()
    {
        Console.Write("Please Input Registered Value : ");
        return double.Parse(Console.ReadLine());
    }
    public static string InputMoney()
    {
        Console.Write("Please Input Money : ");
        return Console.ReadLine();
    }
    public static double ConvertStringToDouble(string value){
        if (double.TryParse(value, out double total)){
            return total;
        }
        throw new Exception("Error");
    }
        public void PrintInformation(string name, double number, string ownername, double value)
    {
        Console.WriteLine("----------Shop Information----------");
        Console.WriteLine("Name : {0}", name);
        Console.WriteLine("Number : {0}", number);
        Console.WriteLine("Owner Name : {0}", ownername);
        Console.WriteLine("Registered Value : {0}", value);
        Console.WriteLine("------------------------------------");        
    } 
    public static void Main(string[] args){
        string name = InputName();
        double number = InputNumber();
        string ownername = InputOwnerName();
        double value = InputValue();
        string money = InputMoney();
        double total = ConvertStringToDouble(money);
        CovertMoney money1 = new CovertMoney();
        money1.Convert(total);
    }
}