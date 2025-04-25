namespace Ejer._32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] inventario = {
            {50, 40, 90},  
            {30, 60, 20}, 
            {20, 70, 10}   
        };

            for (int j = 0; j < inventario.GetLength(1); j++)
            {
                int total = 0;
                int mayor = int.MinValue;
                int menor = int.MaxValue;
                int tipoMayor = -1;
                int tipoMenor = -1;

                for (int i = 0; i < inventario.GetLength(0); i++)
                {
                    total += inventario[i, j];

                    if (inventario[i, j] > mayor)
                    {
                        mayor = inventario[i, j];
                        tipoMayor = i;
                    }

                    if (inventario[i, j] < menor)
                    {
                        menor = inventario[i, j];
                        tipoMenor = i;
                    }
                }

                Console.WriteLine($"Almacén {j + 1}");
                Console.WriteLine($"Total de dispositivos: {total}");
                Console.WriteLine($"Mayor cantidad de dispositivos en Almacén {j + 1}: {mayor} (Tipo {tipoMayor + 1})");
                Console.WriteLine($"Menor cantidad de dispositivos en Almacén {j + 1}: {menor} (Tipo {tipoMenor + 1})");
                Console.WriteLine();
            }
        }
    }
}
