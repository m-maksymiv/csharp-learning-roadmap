namespace CSharpFundamentals.NonPrimitiveTypes;

public static partial class NonPrimitiveTypes
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3,
    }

    private static void Enums()
    {
        Console.WriteLine("Start -> Enums");

        var method = ShippingMethod.Express;
        Console.WriteLine((int)method); //Output: 3

        var methodId = 3;
        Console.WriteLine((ShippingMethod)methodId); //Output: Express

        Console.WriteLine(method.ToString());  //Output: Express

        var methodName = "Express";

        var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

        Console.WriteLine("Finish -> Enums");
    }
}
