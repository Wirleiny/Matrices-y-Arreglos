namespace Ejer._33
{
    internal class Program
    {
        static void MostrarEstudiantes(string[] nombres, int[] calificaciones)
        {
            Console.WriteLine("Resultados:\n");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Nombre: {nombres[i]}");
                Console.WriteLine($"Calificación: {calificaciones[i]}\n"); 
            }
        }

        static void Main(string[] args)
        {
            
            string[] nombres = new string[3];
            int[] calificaciones = new int[3];

            
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Ingrese el nombre del estudiante {i + 1}: ");
                nombres[i] = Console.ReadLine();

                Console.Write($"Ingrese la calificación de {nombres[i]}: ");
                calificaciones[i] = int.Parse(Console.ReadLine());

               
                if (i < 2)
                {
                    Console.WriteLine();
                }
            }

            
            Console.Clear(); 
            MostrarEstudiantes(nombres, calificaciones);
        }
    }
}