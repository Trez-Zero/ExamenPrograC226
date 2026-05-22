/*Contexto

Una tienda de tecnología desea registrar las ventas realizadas durante una semana.
El sistema será desarrollado en equipos de 4 estudiantes utilizando arreglos en C#.*/

//Integrante 1, Ricardo Hamad
        string[] nombres = new string[10];
        double[] precios = new double[10];
        int[] cantidades = new int[10];
        int contadorProductos = 0; 
//Integrante 2, Sergio Cabrera
int opcion;

do
{
    Console.WriteLine("===== MENÚ =====");
    Console.WriteLine("1. Registrar productos");
    Console.WriteLine("2. Mostrar productos");
    Console.WriteLine("3. Calcular total vendido");
    Console.WriteLine("4. Mostrar producto más vendido");
    Console.WriteLine("5. Mostrar promedio de ventas");
    Console.WriteLine("6. Salir");
    Console.Write("Seleccione una opción: ");

    // Validación de la opción del menú
    while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 6)
    {
        Console.WriteLine("Error: opción inválida.");
        Console.Write("Seleccione una opción válida entre 1 y 6: ");
    }

    Console.WriteLine();

    switch (opcion)
    {
        case 1:
            Console.WriteLine("REGISTRO DE PRODUCTOS");

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Producto #" + (i + 1));

                // Entrada y validación del nombre
                do
                {
                    Console.Write("Ingrese el nombre del producto: ");
                    nombres[i] = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(nombres[i]))
                    {
                        Console.WriteLine("Error: el nombre no puede estar vacío.");
                    }

                } while (string.IsNullOrWhiteSpace(nombres[i]));

                // Entrada y validación del precio
                Console.Write("Ingrese el precio del producto: ");

                while (!double.TryParse(Console.ReadLine(), out precios[i]) || precios[i] <= 0)
                {
                    Console.WriteLine("Error: el precio debe ser un número mayor que 0.");
                    Console.Write("Ingrese nuevamente el precio: ");
                }

                // Entrada y validación de la cantidad vendida
                Console.Write("Ingrese la cantidad vendida: ");

                while (!int.TryParse(Console.ReadLine(), out cantidades[i]) || cantidades[i] < 0)
                {
                    Console.WriteLine("Error: la cantidad debe ser un número entero igual o mayor que 0.");
                    Console.Write("Ingrese nuevamente la cantidad vendida: ");
                }

                Console.WriteLine("Producto registrado correctamente.");
                Console.WriteLine();
            }

            break;

        case 2:
            Console.WriteLine("Opción seleccionada: Mostrar productos.");
            Console.WriteLine("Aquí el integrante 4 mostrará los productos registrados.");
            break;

        case 3:
            Console.WriteLine("Opción seleccionada: Calcular total vendido.");
            Console.WriteLine("Aquí el integrante 3 calculará el total vendido.");
            break;

        case 4:
            Console.WriteLine("Opción seleccionada: Mostrar producto más vendido.");
            Console.WriteLine("Aquí el integrante 3 buscará el producto más vendido.");
            break;

        case 5:
            Console.WriteLine("Opción seleccionada: Mostrar promedio de ventas.");
            Console.WriteLine("Aquí el integrante 3 calculará el promedio.");
            break;

        case 6:
            Console.WriteLine("Saliendo del programa...");
            break;
    }

    Console.WriteLine();

} while (opcion != 6);


//Integrante 3, Jonas Hodson
if (opcion == 2)
{
    Console.WriteLine("\nProducto\tPrecio\tCantidad");
    Console.WriteLine("---------------------------------");
    
    if (contadorProductos == 0)
    {
        Console.WriteLine("(No hay productos registrados aún)");
    }
    else
    {
        for (int i = 0; i < contadorProductos; i++)
        {
            Console.WriteLine($"{nombres[i]}\t\t{precios[i]}\t{cantidades[i]}");
        }
    }
}
else if (opcion == 3)
{
    double totalVendido = 0;
    for (int i = 0; i < contadorProductos; i++)
    {
        totalVendido += precios[i] * cantidades[i];
    }
    Console.WriteLine($"\nEl monto total acumulado es: ${totalVendido}");
}
else if (opcion == 4)
{
    if (contadorProductos == 0)
    {
        Console.WriteLine("\n[Aviso] No hay productos registrados para evaluar.");
    }
    else
    {
        int maxCantidad = cantidades[0];
        string productoMasVendido = nombres[0];

        for (int i = 1; i < contadorProductos; i++)
        {
            if (cantidades[i] > maxCantidad)
            {
                maxCantidad = cantidades[i];
                productoMasVendido = nombres[i];
            }
        }
        Console.WriteLine("\n--- PRODUCTO MÁS VENDIDO ---");
        Console.WriteLine($"Nombre del producto: {productoMasVendido}");
        Console.WriteLine($"Cantidad vendida: {maxCantidad}");
    }
}
else if (opcion == 5)
{
    if (contadorProductos == 0)
    {
        Console.WriteLine("\n[Aviso] No se puede calcular el promedio sin productos.");
    }
    else
    {
        double totalAcumulado = 0;
        for (int i = 0; i < contadorProductos; i++)
        {
            totalAcumulado += precios[i] * cantidades[i];
        }
        double promedio = totalAcumulado / contadorProductos;
        Console.WriteLine($"\nEl promedio de ventas es: ${promedio}");
    }
}




