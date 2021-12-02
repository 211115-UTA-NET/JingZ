// See https://aka.ms/new-console-template for more information
class ExceptionPrac {
    public static void Main(string[] arg){
        int[] nums = { 1, 2, 3};
        Console.Write("try calling nums array\nEnter a index number: ");
        int i = int.Parse(Console.ReadLine());
        try{
            Console.WriteLine($"Call nums[{i}]: {nums[i]}");
        } catch (Exception e){
            Console.WriteLine("Catch block executed: Exception occurs" + e.StackTrace);
        } finally{
            Console.WriteLine("Finally will always run!");
        }
        // handle throw
        try
        {
            ThrowMethod(i);
        } catch(Exception){
            Console.WriteLine("Exception throw from a method");
        }
    }

    public static void ThrowMethod(int i){
        throw new Exception();  // tjrow back to main
    }
}