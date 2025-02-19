

using EjercicioExcepciones;
FileStream file = null;
try
{
    int opcion;
    Operaciones operaciones = new Operaciones();

    double n1, n2, suma, resta, multiplicaion, division;
    do
    {

        Console.WriteLine("Menú:");
        Console.WriteLine("1. suma");
        Console.WriteLine("2. resta");
        Console.WriteLine("3. multiplicacion");
        Console.WriteLine("4. division");
        Console.Write("Seleccione una opción: ");

        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:

                Console.Write("Ingrese primer numero: ");
                n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese segundo numero: ");
                n2 = Convert.ToInt32(Console.ReadLine());

                suma = operaciones.suma(n1, n2);

                Console.WriteLine($"La suma es:{suma}");

                break;

            case 2:


                Console.Write("Ingrese primer numero: ");
                n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese segundo numero: ");
                n2 = Convert.ToInt32(Console.ReadLine());

                resta = operaciones.resta(n1, n2);
                Console.WriteLine($"La resta es:{resta}");
                break;

            case 3:

                Console.Write("Ingrese primer numero: ");
                n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese segundo numero: ");
                n2 = Convert.ToInt32(Console.ReadLine());

                multiplicaion = operaciones.multiplicacion(n1, n2);
                Console.WriteLine($"La multiplicacion es:{multiplicaion}");
                break;

            case 4:

                Console.Write("Ingrese primer numero: ");
                n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese segundo numero: ");
                n2 = Convert.ToInt32(Console.ReadLine());

                division = operaciones.division(n1, n2);

                Console.WriteLine($"La division es:{division}");

                break;



            default:

                Console.WriteLine("Opcion no valida, Ingrese un munero del 1 al 4");
                break;
        }



    } while (opcion >4 || opcion<1);
    
   

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