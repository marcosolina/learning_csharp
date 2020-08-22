using System;


class GlazerCalc
{
    static void Main()
    {
        double width, height, woodLength, glassArea;
        string widthString, heightString;

        Console.Write("Type the width in metres: ");
        widthString = Console.ReadLine();//input provided in meters
        width = double.Parse(widthString);

        Console.Write("Type the height in metres: ");
        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        woodLength = 2 * (width + height) * 3.25;// convert into feet
        glassArea = 2 * (width * height);

        Console.WriteLine("The length of the wood is " + woodLength + " feet");
        Console.WriteLine("The area of the glass is " + glassArea + " square metres");
    }
}
