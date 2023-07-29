namespace Ejercicio3
{
    using System.ComponentModel.DataAnnotations;

    //Define una clase llamada "Círculo" con una propiedad privada "radio"
    //y métodos públicos para obtener y establecer el radio.
    //Asegúrate de validar que el radio no sea negativo en el método de establecimiento.

    internal class Program
    {
        static void Main(string[] args)
        {
            var circulo = new Circulo();

            Console.WriteLine("Ingrese el valor del radio del circulo");

            var radio = double.Parse(Console.ReadLine()!);

            if (radio < 0)
            {
                Console.WriteLine("El numero debe ser mayor que cero boludo");
                return;
            }

            circulo.SetRadio(radio);

            var radioCirculo = circulo.GetRadio();

            Console.WriteLine($"El radio del circulo es {radioCirculo}");
        }
    }
}