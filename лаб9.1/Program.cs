using System;

class MyClass
{
    private double number1;
    private double number2;
    public MyClass(double num1, double num2)
    {
        number1 = num1;
        number2 = num2;
    }
    public string GetInfo()
    {
        return $"Number 1: {number1}, Number 2: {number2}";
    }
    public double CalculateSemiDifference()
    {
        return (number1 - number2) / 2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass(10.5, 4.5);
        Console.WriteLine(myObject.GetInfo());
        double semiDifference = myObject.CalculateSemiDifference();
        Console.WriteLine($"Semi-difference: {semiDifference}");
    }
}
