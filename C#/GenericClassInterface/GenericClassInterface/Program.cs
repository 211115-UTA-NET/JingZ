namespace GenericPractice
{
    public class Practice<T> : IPractice<T>
    {
        public T? Data { get; set; }
        public T? InterfaceData { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            Practice<string> str = new();
            str.Data = "Hello";
            str.InterfaceData = "interface string";
            Console.WriteLine(str.Data + " & " + str.InterfaceData);
            Practice<int> num = new();
            num.Data = 136;
            Console.WriteLine(num.Data);
            Practice<bool> boolVal = new();
            boolVal.Data = true;
            Console.WriteLine(boolVal.Data);
        }
    }
}