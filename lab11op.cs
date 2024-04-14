using System;

abstract class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public abstract void Start();
    public void ShowInfo()
    {
        Console.WriteLine($"Brand: {Brand}; Model: {Model}");
    }
}
interface IDriveable
{
    void Drive();
}
class Car : Vehicle, IDriveable
{
    public override void Start()
    {
        Console.WriteLine("Car engine was started");
    }
    public void Drive()
    {
        Console.WriteLine("The car is being driven");
    }
}
class Bicycle : Vehicle, IDriveable
{
    public override void Start()
    {
        Console.WriteLine("Started pedaling the bicycle");
    }
    public void Drive()
    {
        Console.WriteLine("The bicycle is being ridden");
    }
}
abstract class TextProcessor
{
    public abstract string ProcessText(string input);
}
class UpperProcessor : TextProcessor
{
    public override string ProcessText(string input)
    {
        return input.ToUpper();
    }
}
class LowerProcessor : TextProcessor
{
    public override string ProcessText(string input)
    {

        return input.ToLower();
    }
}
class ReplaceProcessor : TextProcessor
{
    public override string ProcessText(string input)
    {
        return input.Replace(' ', '-');
    }
}
class SubProcessor : TextProcessor
{
    public override string ProcessText(string input)
    {
        return input.Substring(4);
    }
}
class Program
{
    static void Main()
    {
        Car newCar = new Car { Brand = "Mazda", Model = "Miata" };
        Bicycle newBicycle = new Bicycle { Brand = "Unknown", Model = "Any" };

        newCar.Start();
        newCar.Drive();
        newCar.ShowInfo();

        Console.WriteLine("\n");

        newBicycle.Start();
        newBicycle.Drive();
        newBicycle.ShowInfo();

        Console.ReadKey();

        TextProcessor upperproc = new UpperProcessor();
        TextProcessor lowerproc = new LowerProcessor();
        TextProcessor replaceproc = new ReplaceProcessor();
        TextProcessor subproc = new SubProcessor();

        Console.WriteLine("\nEnter any words: ");
        string text = Convert.ToString(Console.ReadLine());
        Console.WriteLine("\nYour text: \n" + text);
        Console.WriteLine("Upper case: \n" + upperproc.ProcessText(text));
        Console.WriteLine("Lower case: \n" + lowerproc.ProcessText(text));
        Console.WriteLine("Replaced: \n" + replaceproc.ProcessText(text));
        Console.WriteLine("Sub: \n" + subproc.ProcessText(text));

        Console.ReadKey();
    }
}