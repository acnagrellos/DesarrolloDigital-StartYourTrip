using ClasesObjetos;

internal class Program
{
    private static void Main(string[] args)
    {
        var person1 = new Persona("Juan", "Garcia", 29);
        var person2 = new Persona("Pepe", "Botella", 16);

        Console.WriteLine(person1.GetCompleteName());
        Console.WriteLine(person1.GetAgeMessage());
        person2.AddMoney(80);

        Console.WriteLine($"El dinero que tiene {person2.GetCompleteName()} es {person2.Money}");
        Console.WriteLine($"La mayoría de edad es {Persona.MAX_AGE}");
    }
}