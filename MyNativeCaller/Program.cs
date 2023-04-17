using System.Runtime.InteropServices;

var nativeLib = args[0];

var lib = NativeLibrary.Load(nativeLib);
var handle = NativeLibrary.GetExport(lib, "my_cs_func");
var fn = Marshal.GetDelegateForFunctionPointer<Action>(handle);

Console.WriteLine(lib);

fn();
fn();
fn();

NativeLibrary.Free(lib);
