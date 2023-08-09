namespace ABC.NameSpaceIssueCheck;

using ABC.DEF.Lib1;
using DEF.Lib1;

internal class Class1
{
    public string GetMessage()
    {
        Console.WriteLine(new Class2().GetMessage());
        Console.WriteLine(new Class3().GetMessage());

        return "hello from class A";
    }
}
