class Program
{
    static void Main(string[] args)
    {
        string[] disciplinas = new string[5];          // hasta 5 disciplinas
        string[,] deportistas = new string[5, 10];     // cada disciplina con hasta 10 deportistas
        int[] conteo = new int[5];                     // cantidad de deportistas por disciplina
        int totalDisciplinas = 0;

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("\n=== Premiación de Deportistas ===");
            Console.WriteLine("1. Registrar deportista");
            Console.WriteLine("2. Consultar por disciplina");
            Console.WriteLine("3. Ver reporte general");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Ingrese la disciplina: ");
                string disciplina = Console.ReadLine();

                int index = -1;
                for (int i = 0; i < totalDisciplinas; i++)
                {
                    if (disciplinas[i] == disciplina)
                    {
                        index = i;
                        break;
                    }
                }

                if (index == -1 && totalDisciplinas < 5)
                {
                    index = totalDisciplinas;
                    disciplinas[index] = disciplina;
                    conteo[index] = 0;
                    totalDisciplinas++;
                }

                if (index != -1 && conteo[index] < 10)
                {
                    Console.Write("Ingrese el nombre del deportista: ");
                    string nombre = Console.ReadLine();
                    deportistas[index, conteo[index]] = nombre;
                    conteo[index]++;
                    Console.WriteLine("Deportista registrado con éxito.");
                }
                else
                {
                    Console.WriteLine("No se pudo registrar el deportista.");
                }
            }
            else if (opcion == "2")
            {
                Console.Write("Ingrese la disciplina: ");
                string disciplina = Console.ReadLine();

                int index = -1;
                for (int i = 0; i < totalDisciplinas; i++)
                {
                    if (disciplinas[i] == disciplina)
                    {
                        index = i;
                        break;
                    }
                }

                if (index != -1)
                {
                    Console.WriteLine("Deportistas en " + disciplina + ":");
                    for (int j = 0; j < conteo[index]; j++)
                    {
                        Console.WriteLine("- " + deportistas[index, j]);
                    }
                }
                else
                {
                    Console.WriteLine("Disciplina no encontrada.");
                }
            }
            else if (opcion == "3")
            {
                Console.WriteLine("\n=== Reporte General ===");
                for (int i = 0; i < totalDisciplinas; i++)
                {
                    Console.WriteLine("Disciplina: " + disciplinas[i]);
                    for (int j = 0; j < conteo[i]; j++)
                    {
                        Console.WriteLine("  - " + deportistas[i, j]);
                    }
                }
            }
            else if (opcion == "4")
            {
                continuar = false;
                Console.WriteLine("Fin del programa.");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
    }
}
