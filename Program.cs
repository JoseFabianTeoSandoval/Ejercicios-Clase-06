static void ejemplo1()
{
    int[] calificaciones;
    calificaciones = new int[] { 85, 92, 77, 68, 94 };
    foreach (int calificacion in calificaciones)
    {
        Console.WriteLine(calificacion);
    }
    
}

static void ejemplo2()
{ 
    //ejemplo de promedio utilizando foreach y length
}

static void ejemplo3()
{
    //sacar promedio con for ysolo sumar los pares
    int[] calificaciones;
    calificaciones = new int[] { 85, 92, 77, 68, 94, 80, 99, 67, 88, 70};
    foreach (int calificacion in calificaciones)
    {
        Console.WriteLine(calificacion);
    }
}

static void ejemplo4()
{
    int[] calificaciones;
    calificaciones = new int[] { 85, 92, 77, 68, 94, 80, 99, 67, 88, 70 };
    Array.Sort(calificaciones);
    foreach (int calificacion in calificaciones)
    {
        Console.WriteLine(calificacion);
    }
}

static void despliegue(int[] arreglo)
{
    foreach (int item in arreglo)
    {
        Console.WriteLine(item);
    }
}
static void ejemplo10()
{
    int[] elementos = new int[] { 50, 20, 80, 90, 60 };
    Console.WriteLine("original: ");
    despliegue(elementos);
    Console.WriteLine("ordenado: ");
    Array.Sort(elementos);
    despliegue(elementos);
    Console.WriteLine("reverso");
    Array.Reverse(elementos);
    despliegue(elementos);
    //buscar 90 y 105utilizando indexof
}
ejemplo10();

static void ejemplo5()
{
    int[] calificaciones = { 85, 92, 77, 68, 94 };
    bool hayaprobados = Array.Exists(calificaciones, calif => calif >= 60);
}