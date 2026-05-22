/*Contexto

Una tienda de tecnología desea registrar las ventas realizadas durante una semana.
El sistema será desarrollado en equipos de 4 estudiantes utilizando arreglos en C#.*/

//Integrante 1, Ricardo Hamad



//Integrante 2, Sergio Cabrera
int opcion = 0;

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

    try
    {
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("===== REGISTRO DE PRODUCTOS =====");

                for (int i = 0; i < nombres.Length; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Producto #" + (i + 1));

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
                            Console.WriteLine("Error: debe ingresar un número válido para el precio.");
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
                            Console.WriteLine("Error: debe ingresar un número entero válido para la cantidad.");
                        }
                    }

                    contadorProductos++;
                    Console.WriteLine("Producto registrado correctamente.");
                }

                break;

            case 2:
                Console.WriteLine("Opción seleccionada: Mostrar productos.");
                break;

            case 3:
                Console.WriteLine("Opción seleccionada: Calcular total vendido.");
                break;

            case 4:
                Console.WriteLine("Opción seleccionada: Mostrar producto más vendido.");
                break;

            case 5:
                Console.WriteLine("Opción seleccionada: Mostrar promedio de ventas.");
                break;

            case 6:
                Console.WriteLine("Saliendo del sistema...");
                break;

            default:
                Console.WriteLine("Opción inválida. Ingrese un número del 1 al 6.");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: debe ingresar un número válido para la opción del menú.");
    }

    Console.WriteLine();

} while (opcion != 6);


//Integrante 3, Jonas Hodson



//Integrante 4, Ervin Rocha

