namespace Ejer._39
{
    internal class Program
    {
           class Operacion
        {
            public virtual void RealizarOperacion()
            {
                Console.WriteLine("Operación básica.");
            }
        

        class Suma : Operacion
        {
            public override void RealizarOperacion()
            {
                Console.WriteLine("Operación de Suma.");
                Console.Write("Ingrese el primer número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado de la suma: {num1 + num2}");
            }
        }

      
        class Resta : Operacion
        {
            public override void RealizarOperacion()
            {
                Console.WriteLine("Operación de Resta.");
                Console.Write("Ingrese el primer número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado de la resta: {num1 - num2}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Operacion operacion;

               
                Console.WriteLine("Seleccione la operación (1: Suma, 2: Resta): ");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                    operacion = new Suma();
                else
                    operacion = new Resta();

                
                operacion.RealizarOperacion();

                Console.ReadLine();
            }
        }
     }
  }

}

