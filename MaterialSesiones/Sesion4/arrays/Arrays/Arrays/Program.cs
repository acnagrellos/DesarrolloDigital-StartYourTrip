internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Primer ejercicio");
        string[] arrayStrings = ["Manzana", "Platano", "Naranja", "Pera", "Melocoton"];

        foreach (var str in arrayStrings) {
            Console.WriteLine(str);
        }
        Console.WriteLine("------------------------------");

        Console.WriteLine("Tercer ejercicio");
        var arrayOrdered = arrayStrings.OrderBy(str => str);

        foreach (var str in arrayOrdered)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine("------------------------------");

        Console.WriteLine("Cuarto ejercicio");
        int index = 1;
        var arrayConverted = arrayStrings.Select(str => $"{index++}.{str}");

        foreach (var str in arrayConverted)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine("------------------------------");


        Console.WriteLine("Quinto ejercicio");
        int[] numbersArray = [12, 3, 56, 7, 109, 65];

        var maxNumber = 0;
        foreach (var num in numbersArray)
        {
            if (num > maxNumber) 
            {
                maxNumber = num;
            }
        }
        Console.WriteLine($"Número máximo: {maxNumber}");
        Console.WriteLine("------------------------------");

        Console.WriteLine("Septimo ejercicio");
        var maxNumber2 = numbersArray.Max();
        Console.WriteLine($"Número máximo: {maxNumber}");

        Console.WriteLine("Octavo ejercicio");
        var sumNumbers = 0;
        foreach (var num in numbersArray)
        {
            sumNumbers += num;
        }
        Console.WriteLine($"Suma de los números: {sumNumbers}");
        Console.WriteLine("------------------------------");

        Console.WriteLine("Septimo ejercicio");
        var sumNumbers2 = numbersArray.Sum();
        Console.WriteLine($"Suma de los números: {sumNumbers2}");

    }
}