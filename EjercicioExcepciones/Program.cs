

using EjercicioExcepciones;

try
{
    Operaciones operaciones = new Operaciones();
    double n1, n2, suma, resta, multiplicaion, division;


    Console.Write("Ingrese primer numero: ");
    n1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese segundo numero: ");
    n2 = Convert.ToInt32(Console.ReadLine());

    
    suma=operaciones.suma(n1, n2);
    resta=operaciones.resta(n1, n2);
    multiplicaion=operaciones.multiplicacion(n1, n2);
    division=operaciones.division(n1, n2);

    Console.WriteLine($"La suma es:{suma}");
    Console.WriteLine($"La resta es:{resta}");
    Console.WriteLine($"La multiplicacion es:{multiplicaion}");
    Console.WriteLine($"La division es:{division}");
 

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