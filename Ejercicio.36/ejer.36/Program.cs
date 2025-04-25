namespace ejer._36
{
    internal class Program
    {
        class Animal
        {
            public virtual void HacerSonido()
            {
                Console.WriteLine("Este animal hace un sonido.");
            }
        }
        class Perro : Animal
        {
            public override void HacerSonido()
            {
                Console.WriteLine("El perro hace: ¡Guau! ¡Guau!");
            }
        }


        class Gato : Animal
        {
            public override void HacerSonido()
            {
                Console.WriteLine("El gato hace: ¡Miau! ¡Miau!");
            }
        }

        static void Main(string[] args)
        {
           
            Animal miPerro = new Perro();
            Animal miGato = new Gato();

           
            Console.WriteLine("¿De qué animal quieres saber el sonido? (perro/gato): ");
            string animal = Console.ReadLine().ToLower();

            
            if (animal == "perro")
            {
                miPerro.HacerSonido();
            }
            else if (animal == "gato")
            {
                miGato.HacerSonido();
            }
            else
            {
                Console.WriteLine("Error, Vuelve a intentarlo bb");


            }
        }
    }
}
