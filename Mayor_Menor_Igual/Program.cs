namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Ingrese un número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine(n1 + " es mayor a " + n2);
            }
            else if (n2 > n1)
            {
                Console.WriteLine(n2 + " es mayor a " + n1);
            }
            else
            {
                Console.WriteLine("Ambos números son iguales");
            }
            Console.ReadLine();
        }
    }
}