static void suma()
{
    int respuesta, val1, val2 = 0;
    Console.WriteLine("ingrese valor 1:");
    val1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("ingrese valor 2:");
    val2 = Convert.ToInt32(Console.ReadLine());
    respuesta = val1 + val2;
    Console.WriteLine("suma=" + respuesta);
}


//ejercicio 2
static void datos()
{
    
    Console.WriteLine("Cual es su nombre:");
    string nombre = Console.ReadLine();
    Console.WriteLine("mucho gusto:" + nombre);
}


//ejercicio 3
static void calculoEdad()
{
    Console.WriteLine("Ingrese su año de nacimiento:");
    int yearBorn = Convert.ToInt32(Console.ReadLine());
    int edad = yearBorn - 2024;
    Console.WriteLine("su edad es=" + edad);
}






    static int suma1(int val1, int val2, int val3)
    {
        return val1 + val2 + val3;

    }
    int promedio = suma1(30, 20, 40) / 3;
    Console.WriteLine(promedio);
    promedio = suma1(50, 60, 90);

