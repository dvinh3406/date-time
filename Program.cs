internal class Program
{
    private static void Main(string[] args)
    {
        DateTime dateTime= DateTime.Now;
        Console.WriteLine("{0}{1}{2}", dateTime.Hour, dateTime.Minute, dateTime.Second);
    }
}