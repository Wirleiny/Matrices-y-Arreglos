namespace Ejer._34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos números desea ingresar? ");
            int cantidad = int.Parse(Console.ReadLine());

            
            int[] numeros = new int[cantidad];
            int suma = 0;

           
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
                suma += numeros[i];

                
                if (suma >= 100)
                {
                    Console.WriteLine($"La sumatoria es mayor a 100, El resultado total es: {suma}");
                    return;  
                }
            }

            
            Console.WriteLine($"La sumatoria total de los números es: {suma}");
        
        }
    }
}
