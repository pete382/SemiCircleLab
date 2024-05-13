// See https://aka.ms/new-console-template for more information


using Microsoft.VisualBasic;
using SemiCircleLab;
using System.Threading.Channels;

double Radius = 0;
bool isNumber = true;
bool isGrow = false;


Circle MyCircle = new Circle(Radius);
Console.WriteLine("Please enter a radius.");


    while (isNumber)
{


    try
    {

        Radius = double.Parse(Console.ReadLine());
        isNumber = false;
    }




    catch (FormatException e)
    { Console.WriteLine("Please enter a valid number."); }


}


    Console.WriteLine("Will the circle grow? Type 'y' for YES and 'n' for NO.");


string growQuestion = Console.ReadLine().ToLower();

if (growQuestion == "n")

{ Radius = Radius; }

else if (growQuestion == "y")

{ Radius = Radius * 2; }

else { }
    //Radius = MyCircle.Grow;






Console.WriteLine($"Diameter: {MyCircle.CalculateDiameter(Radius)}");
Console.WriteLine($"Circumference: {MyCircle.CalculateCircumference(Radius)}");
Console.WriteLine($"Area: {MyCircle.CalculateArea(Radius)}");

