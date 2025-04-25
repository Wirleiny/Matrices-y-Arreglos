namespace Ejer._31_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo1 = new int[10];
            int[] arreglo2 = new int[10];
            int[] sumaArreglos = new int[10];

            Console.WriteLine("Ingrese los primeros 10 números:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Número {i + 1}: ");
                arreglo1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese los segundos 10 números ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Número {i + 1}: ");
                arreglo2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                sumaArreglos[i] = arreglo1[i] + arreglo2[i];
            }

            Console.WriteLine("Resultado de la suma de los arreglos:");
            foreach (int num in sumaArreglos)
            {
                Console.WriteLine(num);

            }
        }
    }
}
