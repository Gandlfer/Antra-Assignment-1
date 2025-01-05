namespace _02UnderStandingTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int  temp= int.MaxValue;
            Console.WriteLine(temp+1);
            string type = "sbyte";
            Console.WriteLine(type+" number of bytes "+sizeof(sbyte));
            Console.WriteLine(type+" Max Value "+sbyte.MaxValue);
            Console.WriteLine(type + " Min Value " + sbyte.MinValue);
            type = "byte";
            Console.WriteLine(type + " number of bytes " + sizeof(byte));
            Console.WriteLine(type + " Max Value " + byte.MaxValue);
            Console.WriteLine(type + " Min Value " + byte.MinValue);
             type = "short";
            Console.WriteLine(type + " number of bytes " + sizeof(short));
            Console.WriteLine(type + " Max Value " + short.MaxValue);
            Console.WriteLine(type + " Min Value " + short.MinValue);
             type = "ushort";
            Console.WriteLine(type + " number of bytes " + sizeof(ushort));
            Console.WriteLine(type + " Max Value " + ushort.MaxValue);
            Console.WriteLine(type + " Min Value " + ushort.MinValue);
             type = "int";
            Console.WriteLine(type + " number of bytes " + sizeof(int));
            Console.WriteLine(type + " Max Value " + int.MaxValue);
            Console.WriteLine(type + " Min Value " + int.MinValue);
             type = "uint";
            Console.WriteLine(type + " number of bytes " + sizeof(uint));
            Console.WriteLine(type + " Max Value " + uint.MaxValue);
            Console.WriteLine(type + " Min Value " + uint.MinValue);
            type = "long";
            Console.WriteLine(type + " number of bytes " + sizeof(long));
            Console.WriteLine(type + " Max Value " + long.MaxValue);
            Console.WriteLine(type + " Min Value " + long.MinValue);
             type = "ulong";
            Console.WriteLine(type + " number of bytes " + sizeof(ulong));
            Console.WriteLine(type + " Max Value " + ulong.MaxValue);
            Console.WriteLine(type + " Min Value " + ulong.MinValue);
             type = "float";
            Console.WriteLine(type + " number of bytes " + sizeof(float));
            Console.WriteLine(type + " Max Value " + float.MaxValue);
            Console.WriteLine(type + " Min Value " + float.MinValue);
             type = "double";
            Console.WriteLine(type + " number of bytes " + sizeof(double));
            Console.WriteLine(type + " Max Value " + double.MaxValue);
            Console.WriteLine(type + " Min Value " + double.MinValue);
             type = "decimal";
            Console.WriteLine(type + " number of bytes " + sizeof(decimal));
            Console.WriteLine(type + " Max Value " + decimal.MaxValue);
            Console.WriteLine(type + " Min Value " + decimal.MinValue);


            Console.Write("Input: ");
            int centuries = Convert.ToInt32(Console.ReadLine());
            int years = centuries * 100;
            ulong days = (ulong)(years * 365.2422), hours = days * 24, minutes = hours * 60;
            ulong seconds = minutes * 60, milliseconds = seconds * 1000, microseconds = milliseconds * 1000;
            ulong nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

        }
    }
}
