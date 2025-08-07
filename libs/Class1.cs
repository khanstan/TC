namespace libs;





public static class Class1
{
    public static string Try1() => System.Reflection.Assembly.GetEntryAssembly()!.GetName().Name!;
}
