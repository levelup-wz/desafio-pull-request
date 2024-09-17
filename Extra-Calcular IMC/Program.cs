namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu peso em quilos:");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe sua altura em metros:");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / Math.Pow(altura, 2);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc < 35)
            {
                Console.WriteLine("Obesidade grau 1");
            }
            else if (imc < 40)
            {
                Console.WriteLine("Obesidade grau 2");
            }
            else
            {
                Console.WriteLine("Obesidade grau 3");
            }


            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}