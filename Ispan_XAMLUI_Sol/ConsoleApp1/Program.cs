// See https://aka.ms/new-console-template for more information

A class1= new A();
B class2 = new A();
Console.WriteLine(class1.Method1());
// 顯示"A.Method1"
Console.WriteLine(class2.Method1());
// 顯示"B.Method1"

public class A : B
{
    public string Method1()
    {
        return "A.Method1";
    }
}
public class B
{
    public string Method1()
    {
        return "B.Method1";
    }
}