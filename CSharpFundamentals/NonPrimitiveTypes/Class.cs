namespace CSharpFundamentals.NonPrimitiveTypes;

public static partial class NonPrimitiveTypes
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }

    public class Calcularor
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    private static void Class()
    {
        Console.WriteLine("Start -> Class");

        var person = new Person();

        person.FirstName = "Mykola";
        person.LastName = "Maskymiv";
        person.Introduce(); //Output: My name is Mykola Maksymiv

        var calcularor = new Calcularor();

        var result = calcularor.Add(1, 2);
        Console.WriteLine(result); //Output: 3

        Console.WriteLine("Finish -> Class");
    }
}
