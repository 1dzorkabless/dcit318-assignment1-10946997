using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.Write("Enter the length of the first side: ");
        string input1 = Console.ReadLine();
        Console.Write("Enter the length of the second side: ");
        string input2 = Console.ReadLine();
        Console.Write("Enter the length of the third side: ");
        string input3 = Console.ReadLine();

        double side1, side2, side3;

        if (double.TryParse(input1, out side1) && double.TryParse(input2, out side2) && double.TryParse(input3, out side3) &&
            side1 > 0 && side2 > 0 && side3 > 0)
        {
            string triangleType;

            if (side1 == side2 && side2 == side3)
                triangleType = "Equilateral";
            else if (side1 == side2 || side2 == side3 || side1 == side3)
                triangleType = "Isosceles";
            else
                triangleType = "Scalene";

            Console.WriteLine($"The triangle is: {triangleType}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter positive numerical values for the sides.");
        }
    }
}
