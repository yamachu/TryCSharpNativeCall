using System.Runtime.InteropServices;

namespace MyNativeLibrary;

public class Class1
{
    private static int Num = 0;

    [UnmanagedCallersOnly(EntryPoint = "my_cs_func")]
    public static void MyCSFunc()
    {
        Console.WriteLine($"Hello from C#! C# から こんにちは!, Num: {Num}");
        Num++;
    }
}
