// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("dotNet version 6.0.1 has new framework");
        // Function calls
        Foo(3);
        // Array
        int[] arr1 = { 1, 2, 3};    // Better use new int[...]
        PrintArr(arr1);
        Console.WriteLine("----------------arr1---------------");
        int[] arr2 = new int[] {4,5,6};
        PrintArr(arr2);
        Console.WriteLine("----------------arr2---------------");
        int[] arr3 = new int[3];
        arr3[0] = 7;
        arr3[1] = 8;
        arr3[2] = 9;
        PrintArr(arr3);
        Console.WriteLine("----------------arr3---------------");
        int[] arr4 = { };
        Console.WriteLine("int[] arr4 = { }; Length = " + arr4.Length);
        // int[][] arr5 = {};     // double array
        // List
        Console.WriteLine("----------------List---------------");
        List<string> list = new List<string>();
        list.Add("content 1");
        list.Insert(1, "content 2");
        PrintList(list);
        Console.WriteLine("----------------Set: HashSet---------------");
        Console.WriteLine("Prevent duplicate value");
        HashSet<int> set = new HashSet<int>();
        set.Add(9);
        set.Add(1);
        set.Add(3);
        set.Add(6);
        set.Add(3);
        Console.Write("Set = { ");
        foreach (int value in set)
        {
            Console.Write(value + " ");
        }
        Console.Write("} \nLength of Set = " + set.Count + "\n");
        // Queue
        Console.WriteLine("----------------Queue---------------");
        Console.WriteLine("First In First Out");
        Queue<string> myQueue = new Queue<string>();
        myQueue.Enqueue("first");
        myQueue.Enqueue("second");
        myQueue.Enqueue("third");
        myQueue.Enqueue("fourth");
        Console.Write("Queue = { ");
        foreach (string str in myQueue)
        {
            Console.Write(str+" ");
        }
        Console.Write("} \nLength of Queue = " + myQueue.Count + "\n");
        Console.WriteLine("Peek of queue: " + myQueue.Peek());
        Console.WriteLine("Popping first element out" + myQueue.Dequeue());
        Console.Write("Queue = { ");
        foreach (string str in myQueue)
        {
            Console.Write(str+" ");
        }
        Console.Write("}\n");
        Console.WriteLine("Length of Queue = " + myQueue.Count);
        Console.WriteLine("Peek of queue after dequeue: " + myQueue.Peek());
        // Stack
        Console.WriteLine("----------------Stack---------------");
        Console.WriteLine("Last In First Out");
        Stack<string> myStack = new Stack<string>();
        myStack.Push("first");
        myStack.Push("second");
        myStack.Push("third");
        myStack.Push("fourth");
        Console.Write("Stack = { ");
        foreach (string str in myStack)
        {
            Console.Write(str+" ");
        }
        Console.Write("} \nLength of Stack = " + myStack.Count + "\n");
        Console.WriteLine("Peek of Stack: " + myStack.Peek());
        Console.WriteLine("Popping top element out: " + myStack.Pop());
        Console.Write("Stack = { ");
        foreach (string str in myStack)
        {
            Console.Write(str+" ");
        }
        Console.Write("}\n");
        Console.WriteLine("Length of Stack = " + myStack.Count);
        Console.WriteLine("Peek of stack after pop: " + myStack.Peek());
        // Dictionary
        Console.WriteLine("----------------Dictionary---------------");
        // A dictionary in C# stores <Key, Value> pairs in no particular order. 
        // Index is not numbered.
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        //Add key value pairs to the dictionary using Add() method
        myDictionary.Add(1, "Hello");
        myDictionary.Add(2, "Goodbye");
        //Keys must be unique and cannot be null.
        //Values can be null or duplicate.
        myDictionary.Add(3, "null");
        myDictionary.Add(4, "Hello");
        //Values can be accessed by passing associated key in the indexer
        // Console.WriteLine(myDictionary[1]);
        // Console.WriteLine(myDictionary[2]);
        //You cannot assign multiple values to the same key.
        //myDicitonary.Add(3, "Three"); -- this would return a runtime error
        //Clear() method clears entire dictionary
        foreach(KeyValuePair<int, string> ele in myDictionary)
        {
            Console.WriteLine("{0} -> {1}", ele.Key, ele.Value);
        }
    }

    static void Foo(int i){
        Console.WriteLine("You passed a value is " + i);
    }

    static void PrintArr(int[] arr){
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("arr[" + i + "] = " + arr[i]);
        }
    }

    static void PrintList(List<string> list){
        Console.WriteLine("List = { ");
        foreach (string str in list)
        {
            Console.Write(str + " ");
        }
        Console.WriteLine("}");
    }
}