/*Contexto

Una tienda de tecnología desea registrar las ventas realizadas durante una semana.
El sistema será desarrollado en equipos de 4 estudiantes utilizando arreglos en C#.*/

// Integrante 1, Ricardo Hamad
string[] nombres = new string[10];
double[] precios = new double[10];
int[] cantidades = new int[10];
int contadorProductos = 0;

// Integrante 2, Sergio Cabrera y Integrante 3, Jonas Hodgson
int opcion = 0;

do
{
    Console.ResetColor();
    Console.WriteLine("===== MENÚ =====");
    Console.WriteLine("1. Registrar productos");
    Console.WriteLine("2. Mostrar productos");
    Console.WriteLine("3. Calcular total vendido");
    Console.WriteLine("4. Mostrar producto más vendido");
    Console.WriteLine("5. Mostrar promedio de ventas");
    Console.WriteLine("6. Salir");
    Console.Write("Seleccione una opción: ");

    try
    {
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("===== REGISTRO DE PRODUCTOS =====");
                Console.ResetColor();

                for (int i = 0; i < nombres.Length; i++)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Producto #" + (i + 1));
                    Console.ResetColor();

                    Console.Write("Ingrese el nombre del producto: ");
                    nombres[i] = Console.ReadLine();

                    bool precioCorrecto = false;
                    while (precioCorrecto == false)
                    {
                        try
                        {
                            Console.Write("Ingrese el precio del producto: ");
                            precios[i] = double.Parse(Console.ReadLine());
                            precioCorrecto = true;
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: debe ingresar un número válido para el precio.");
                            Console.ResetColor();
                        }
                    }

                    bool cantidadCorrecta = false;
                    while (cantidadCorrecta == false)
                    {
                        try
                        {
                            Console.Write("Ingrese la cantidad vendida: ");
                            cantidades[i] = int.Parse(Console.ReadLine());
                            cantidadCorrecta = true;
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: debe ingresar un número entero válido para la cantidad.");
                            Console.ResetColor();
                        }
                    }

                    contadorProductos++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Producto registrado correctamente.");
                    Console.ResetColor();
                }
                break;

            case 2:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nProducto\tPrecio\tCantidad");
                Console.WriteLine("---------------------------------");
                Console.ResetColor();

                if (contadorProductos == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("(No hay productos registrados aún)");
                    Console.ResetColor();
                }
                else
                {
                    for (int i = 0; i < contadorProductos; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{nombres[i]}\t\t{precios[i]}\t{cantidades[i]}");
                        Console.ResetColor();
                    }
                }
                break;

            case 3:
                double totalVendido = 0;
                for (int i = 0; i < contadorProductos; i++)
                {
                    totalVendido += precios[i] * cantidades[i];
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nEl monto total acumulado es: ${totalVendido}");
                Console.ResetColor();
                break;

            case 4:
                if (contadorProductos == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n[Aviso] No hay productos registrados para evaluar.");
                    Console.ResetColor();
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
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n--- PRODUCTO MÁS VENDIDO ---");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Nombre del producto: {productoMasVendido}");
                    Console.WriteLine($"Cantidad vendida: {maxCantidad}");
                    Console.ResetColor();
                }
                break;

            case 5:
                if (contadorProductos == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n[Aviso] No se puede calcular el promedio sin productos.");
                    Console.ResetColor();
                }
                else
                {
                    double totalAcumulado = 0;
                    for (int i = 0; i < contadorProductos; i++)
                    {
                        totalAcumulado += precios[i] * cantidades[i];
                    }
                    double promedio = totalAcumulado / contadorProductos;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nEl promedio de ventas es: ${promedio}");
                    Console.ResetColor();
                }
                break;

            case 6:
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Saliendo del sistema...");
                Console.ResetColor();
                break;

            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opción inválida. Ingrese un número del 1 al 6.");
                Console.ResetColor();
                break;
        }
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: debe ingresar un número válido para la opción del menú.");
        Console.ResetColor();
    }

    Console.WriteLine();

} while (opcion != 6);
