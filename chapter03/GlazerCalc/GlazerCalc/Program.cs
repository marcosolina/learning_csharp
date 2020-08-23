using System; // instruction to the C# compiler to tell that I want to use things from the System namespace (in Java is like the import package.name.*)


class GlazerCalc // same concept like in Java
{
    static void Main() // same concept like in Java, but here I can omit the String [] args if it is not required
    {

        double width, height, woodLength, glassArea;
        const double MAX_WIDTH = 5.0;
        const double MIN_WIDTH = 0.5;
        const double MAX_HEIGHT = 3.0;
        const double MIN_HEIGHT = 0.75;

        width = readValue("Give the width of the window", MIN_WIDTH, MAX_WIDTH);
        height = readValue("Give the height of the window", MIN_HEIGHT, MAX_HEIGHT);

        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);

        Console.WriteLine("The length of the wood is " + woodLength + " feet");
        Console.WriteLine("The area of the glass is " + glassArea + " square metres");
    }

    static double readValue(string prompt, double low, double high)
    {
        double result = 0;
        do
        {
            Console.WriteLine(prompt + " between " + low + " and " + high);
            string resultString = Console.ReadLine();
            result = double.Parse(resultString);
        } while ((result < low) || (result > high));
        return result;
    }
}
