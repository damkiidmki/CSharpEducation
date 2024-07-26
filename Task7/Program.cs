internal class Program
{
    public static void Main(string[] args)
    {
        var legOne = 3d;
        var legTwo = 4d;
        var hypotenuse = 5d;
        Console.WriteLine(GetHypotenuse(legTwo, legOne));
        Console.WriteLine(GetLeg(hypotenuse, legOne));
    }

    private static double GetHypotenuse(double legOne, double legTwo)
    {
        return Math.Sqrt(Math.Pow(legOne, 2) + Math.Pow(legTwo, 2));
    }

    private static double GetLeg(double hypotenuse, double leg)
    {
        return Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(leg, 2));
    }
}

