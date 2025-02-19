

try
{
    double n1, n2, division;


    Console.Write("Ingrese primer numero: ");
    n1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese segundo numero: ");
    n2 = Convert.ToInt32(Console.ReadLine());

    division = n1 / n2;
    Console.WriteLine($"La division es:{division}");
    Console.WriteLine($"La division es:{division + 5}");

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
finally
{
    file?.Close();
    Console.WriteLine("El archivo se cerro");
}