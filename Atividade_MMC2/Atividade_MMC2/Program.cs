using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NOME;
            int IDADE;
            float PESO;
            float ALTURA;
            double IMC;

            Console.WriteLine("Bem-vindo ao sistema de calculo de IMC!");
            Console.WriteLine("Para cadastros responda as seguintes perguntas: ");
            Console.WriteLine();
            Console.WriteLine("Qual o seu nome?");
            Console.WriteLine();

            NOME = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Ola, {NOME}. Espero que esteja tudo bem com voce.");
            Console.WriteLine();

            Console.WriteLine($"{NOME}. Quantos anos voce tem?");
            Console.WriteLine();

            IDADE = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Entao voce tem {IDADE} anos de idade? Legal, vamos continuar.");
            Console.WriteLine();

            Console.WriteLine($"{NOME}. Qual o seu peso?: (Utilize virgula para apresenta-lo).");
            Console.WriteLine();

            PESO = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"{PESO} Kgs. Interessante");
            Console.WriteLine();

            Console.WriteLine($"Agora para finalizar. {NOME} qual a sua altura: (Utilize virgula para apresenta-lo).");
            Console.WriteLine();

            ALTURA = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Entendi. Entao sua altura na casa dos {ALTURA} metros");
            Console.WriteLine();

            Console.WriteLine("Agora vamos calcular seu IMC: \n \n(Pressione Enter para continuar.)");
            Console.ReadKey();
            Console.WriteLine();

            Console.Clear();

            Console.WriteLine($"{NOME} te lembrando que:");
            Console.WriteLine("Entre 18,5 e 24,9 = Normal");
            Console.WriteLine("Entre 25 e 29,9 = Sobrepeso");
            Console.WriteLine("Acima de 30 = Obeso");
            Console.WriteLine("Maior que 40 = Obesidade grave \n \n(Pressione Enter para continuar.)");
            Console.WriteLine();
            Console.ReadKey();

            IMC = PESO / (ALTURA * ALTURA);

            if (IMC >= 18 && IMC <= 24.9)
            {
                Console.WriteLine($"{NOME} seu IMC: {IMC}. Esta tudo normal amigo.");
            }

            else if (IMC >= 25 && IMC <= 29.9)
            {
                Console.WriteLine($"{NOME} seu IMC: {IMC}. Esta no sobrepeso, ainda nao esta ruim.");
            }

            else if (IMC >= 30)
            {
                Console.WriteLine($"{NOME} seu IMC: {IMC}. Amigo cuidado voce tem obesidade.");
            }

            else if (IMC >= 40)
            {
                Console.WriteLine($"{NOME} seu IMC: {IMC}. Amigo procure um medico voce esta na obesidade critica.");
            }

            else
            {
                Console.WriteLine($"{NOME} algo deu muito errado, por favor tente de novo.");
            }

            Console.ReadLine();

        }
    }
}
